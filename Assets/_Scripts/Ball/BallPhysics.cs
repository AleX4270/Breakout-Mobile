using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallPhysics : MonoBehaviour
{
    [SerializeField] private BallController ballController;

    private Vector2 bounceDir;
    private Vector2 velocityBufor;
    private Vector2 newVelocity;

    private void Start()
    {
        ballController.gameState.gameStatusChanged += freezeBallPosition;
    }

    private void OnDestroy()
    {
        ballController.gameState.gameStatusChanged -= freezeBallPosition;
    }

    public void calculateBouncePlayer(Collision2D col)
    {
        Vibration.Vibrate(20);

        //bounceDir = (col.GetContact(0).point - (Vector2)col.gameObject.transform.position).normalized;
        bounceDir = ((Vector2)this.transform.position - (Vector2)col.gameObject.transform.position).normalized / col.gameObject.GetComponent<SpriteRenderer>().bounds.size.x;
        //bounceDir.y = 1f;
        bounceDir *= ballController.ballData.speed;
        ballController.rb2d.velocity = bounceDir;
    }

    public void calculateBounceWall(Collision2D col)
    {
        newVelocity = col.GetContact(0).relativeVelocity;
        ballController.rb2d.velocity = new Vector2(newVelocity.x, -newVelocity.y);
    }

    private void freezeBallPosition(object sender, State state)
    {
        if(state == State.paused)
        {
            velocityBufor = ballController.rb2d.velocity;
            ballController.rb2d.constraints = RigidbodyConstraints2D.FreezeAll;
        }
        else if(state == State.running)
        {
            ballController.rb2d.constraints = RigidbodyConstraints2D.FreezeRotation;
            ballController.rb2d.velocity = velocityBufor;
        }
    }
}
