using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private Touch touch;

    [Header("UI")] 
    public Button startBtn;

    [Header("Ball")] 
    public Rigidbody2D ball;
    public BallMovement ballController;

    [Header("Player")] 
    public Rigidbody2D player;
    public PlayerMovement playerController;
    
    public void startGame()
    {
        ballController.freezeBall(false);
        playerController.freezePlayer(false);
        ballController.pushBall();
        startBtn.gameObject.SetActive(false);
    }
}
