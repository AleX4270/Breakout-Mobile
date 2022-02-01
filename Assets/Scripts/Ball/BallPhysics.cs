using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallPhysics : MonoBehaviour
{
    [SerializeField] private BallController ballController;

    private Vector2 bounceDir;
    private Vector2 velocityBufor;

    private void Start()
    {
        ballController.ballState.ballStatusChanged += freezeBallPosition;
    }

    private void Update()
    {
        
    }

    public void calculateBouncePlayer(Collision2D col)
    {
        Vibration.Vibrate(20);

        bounceDir = (col.GetContact(0).point - (Vector2)col.gameObject.transform.position).normalized;
        ballController.rb2d.velocity = bounceDir * ballController.ballData.speed * Time.deltaTime;
    }

    public void calculateBounceWall(Collision2D col)
    {
        ballController.rb2d.velocity = col.GetContact(0).relativeVelocity;
    }

    public void freezeBallPosition(object sender, BState state)
    {
        if(state == BState.freezed)
        {
            velocityBufor = ballController.rb2d.velocity;
            ballController.rb2d.constraints = RigidbodyConstraints2D.FreezeAll;
        }
        else if(state == BState.inGame)
        {
            ballController.rb2d.constraints = RigidbodyConstraints2D.FreezeRotation;
            ballController.rb2d.velocity = velocityBufor;
        }
    }
}
