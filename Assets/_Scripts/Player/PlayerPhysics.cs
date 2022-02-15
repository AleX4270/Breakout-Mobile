using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPhysics : MonoBehaviour
{
    [SerializeField] private PlayerController playerController;
    private Vector2 velocityBufor;
    private Vector2 updatedPosition;

    private float leftBound, rightBound;

    private void Start()
    {
        playerController.gameState.gameStatusChanged += freezePlayerPosition; 
        updatedPosition.y = transform.position.y;

        leftBound = -(playerController.playerData.cameraWidth / 2) + 
            (playerController.playerData.playerWidth / 2);

        rightBound = (playerController.playerData.cameraWidth / 2) -
            (playerController.playerData.playerWidth / 2);
    }

    private void OnDestroy()
    {
        playerController.gameState.gameStatusChanged -= freezePlayerPosition;
    }

    public void movePlayer(Vector2 newPosition)
    {
        if(Mathf.Abs(newPosition.y - playerController.rb2d.position.y) < playerController.playerData.offset 
            && playerController.gameState.GState == State.running)
        {
            //playerController.rb2d.MovePosition(newPosition * playerController.playerData.speed * Time.fixedDeltaTime);
            this.updatedPosition.x = Mathf.Lerp(this.transform.position.x, newPosition.x,
                playerController.playerData.speed * Time.fixedDeltaTime);

            this.updatedPosition.x = Mathf.Clamp(this.updatedPosition.x, 
                this.leftBound, this.rightBound);

            playerController.rb2d.position = updatedPosition;
          
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
