using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] internal PlayerData playerData;
    [SerializeField] internal PlayerPhysics playerPhysics;
    [SerializeField] internal PlayerMovement playerMovement;
    [SerializeField] internal PlayerInput playerInput;
    [SerializeField] internal GameState gameState;

    [SerializeField] internal Transform respawnPoint;
    internal Rigidbody2D rb2d;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        calculateCameraWidth();
        calculatePlayerWidth();
    }

    private void calculateCameraWidth()
    {
        playerData.cameraWidth = (Camera.main.orthographicSize * Camera.main.aspect) * 2;
    }

    private void calculatePlayerWidth()
    {
        playerData.playerWidth = this.gameObject.GetComponent<SpriteRenderer>().bounds.size.x;
    }
}
