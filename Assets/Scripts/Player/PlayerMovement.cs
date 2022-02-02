using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private PlayerController playerController;
    private Vector3 newPosition;

    private void Update()
    {
        #if (UNITY_EDITOR)
            UpdatePlayerPositionMouse();
        #else
            UpdatePlayerPosition();
        #endif
    }

    private void UpdatePlayerPosition()
    {
        newPosition = playerController.playerInput.GetTouchPosition();

        playerController.playerPhysics.movePlayer(newPosition);
    }

    private void UpdatePlayerPositionMouse()
    {
        newPosition = playerController.playerInput.GetMousePosition();

        playerController.playerPhysics.movePlayer(newPosition);
    }

    public void respawnPlayer()
    {
        this.transform.position = playerController.respawnPoint.position;
    }
}
