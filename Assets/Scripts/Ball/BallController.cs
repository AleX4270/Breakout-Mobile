using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    internal Rigidbody2D rb2d;
    [SerializeField] internal Transform respawnPoint;

    [SerializeField] internal GameState gameState;
    [SerializeField] internal BallMovement ballMovement;
    [SerializeField] internal BallPhysics ballPhys;
    [SerializeField] internal BallData ballData;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        ballMovement.pushBall(ballData.bounceOffset);
    }


}
