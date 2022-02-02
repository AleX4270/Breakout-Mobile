using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPhysics : MonoBehaviour
{
    [SerializeField] private PlayerController playerController;
    private Vector2 velocityBufor;

    private void Start()
    {
        playerController.gameState.gameStatusChanged += freezePlayerPosition;   
    }

    private void OnDestroy()
    {
        playerController.gameState.gameStatusChanged -= freezePlayerPosition;
    }

    public void movePlayer(Vector2 newPosition)
    {
        if(Mathf.Abs(newPosition.y - playerController.rb2d.position.y) < playerController.playerData.offset)
        {
            playerController.rb2d.MovePosition(newPosition * playerController.playerData.speed * Time.fixedDeltaTime);
        }
    }

    private void freezePlayerPosition(object sender, State state)
    {
        if (state == State.paused)
        {
            velocityBufor = playerController.rb2d.velocity;
            playerController.rb2d.constraints = RigidbodyConstraints2D.FreezeAll;
        }
        else if (state == State.running)
        {
            playerController.rb2d.constraints = RigidbodyConstraints2D.FreezeRotation | RigidbodyConstraints2D.FreezePositionY;
            playerController.rb2d.velocity = velocityBufor;
        }
    }
}
