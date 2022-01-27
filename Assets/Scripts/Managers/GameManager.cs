using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private Touch touch;
    private float playerActualScore;

    [Header("UI")] 
    public Button startBtn;
    public TMP_Text playerScore;

    [Header("Ball")] 
    public Rigidbody2D ball;
    public BallMovement ballController;

    [Header("Player")] 
    public Rigidbody2D player;
    public PlayerMovement playerController;

    private void Start()
    {
        playerActualScore = 0;
    }

    public void startGame()
    {
        ballController.freezeBall(false);
        playerController.freezePlayer(false);
        ballController.pushBall();
        startBtn.gameObject.SetActive(false);
    }

    public void addPoint()
    {
        playerActualScore++;
        playerScore.text = playerActualScore.ToString();
    }
}
