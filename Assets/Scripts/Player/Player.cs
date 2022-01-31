using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Player Components
    [SerializeField] private PlayerData playerData;
    private PlayerPhysics playerPhysics;
    private PlayerInput playerInput;
    private PlayerState playerState;

    [SerializeField] private Transform playerSpawnPoint;
    private Rigidbody2D rb2d;
    private Vector3 touchPosition;
    
    
    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        playerPhysics = GetComponent<PlayerPhysics>();
        playerInput = GetComponent<PlayerInput>();
        playerState = GetComponent<PlayerState>();
    }

    private void FixedUpdate()
    {
        UpdatePlayerPosition();
    }

    private void UpdatePlayerPosition()
    {
        touchPosition = playerInput.GetTouchPosition();

        if(playerState.PState == State.inGame)
        {
            playerPhysics.movePlayer(touchPosition, playerData.Speed, playerData.Offset);
        }
    }
}
