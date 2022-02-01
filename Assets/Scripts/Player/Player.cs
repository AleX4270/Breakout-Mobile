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
    private Vector3 newPosition;
    
    
    private void Start()
    {
        playerPhysics = GetComponent<PlayerPhysics>();
        playerInput = GetComponent<PlayerInput>();
        playerState = GetComponent<PlayerState>();
    }

    private void FixedUpdate()
    {
#if (UNITY_EDITOR)
        UpdatePlayerPositionMouse();
#else
        UpdatePlayerPosition();
#endif
    }

    private void UpdatePlayerPosition()
    {
        newPosition = playerInput.GetTouchPosition();

        playerPhysics.movePlayer(newPosition, playerData.Speed, playerData.Offset, playerState.PState);
    }

    private void UpdatePlayerPositionMouse()
    {
        newPosition = playerInput.GetMousePosition();

        playerPhysics.movePlayer(newPosition, playerData.Speed, playerData.Offset, playerState.PState);
    }
}
