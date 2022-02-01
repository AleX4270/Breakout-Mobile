using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    
    /*
    private Touch touch;
    private bool gamePaused;
    private Vector2 ballVel;

    [Header("Player Stats")] 
    public float playerStartHealth;
    private float playerCurrentHealth;
    private float playerActualScore;
    private float playerHighScore;

    [Header("UI")] 
    public Button startBtn;
    public TMP_Text playerScore;
    public TMP_Text playerHealth;

    [Header("Defeat Menu")] 
    public GameObject defeatMenu;
    public TMP_Text gameScore;

    [Header("Pause Menu")] 
    public GameObject pauseMenu;
    public Button pauseBtn;

    [Header("Ball")] 
    public Rigidbody2D ball;
    public BallMovement ballController;

    [Header("Player")] 
    public Rigidbody2D player;
    public PlayerMovement playerController;

    [Header("Bricks")] 
    private BrickController brickCon;

    private void Start()
    {
        this.gamePaused = false;
        this.brickCon = GetComponent<BrickController>();
        this.playerCurrentHealth = this.playerStartHealth;
        this.playerActualScore = 0;
    }

    private void Update()
    {
        if (startBtn.IsActive() || defeatMenu.activeInHierarchy)
            pauseBtn.interactable = false;
        else
            pauseBtn.interactable = true;
    }

    public void startGame()
    {
        ballController.freezeBall(false);
        //playerController.freezePlayer(false);
        ballController.pushBall();
        startBtn.gameObject.SetActive(false);

        if (this.playerCurrentHealth == this.playerStartHealth)
        {
            brickCon.spawnBricks();
        }
    }

    public void addPoint()
    {
        playerActualScore++;
        playerScore.text = playerActualScore.ToString();
    }

    public void takeLife(float count)
    {
        this.playerCurrentHealth -= count;
        this.playerHealth.text = this.playerCurrentHealth.ToString();

        if (this.playerCurrentHealth == 0)
        {
            gameOver();
        }
        else if (this.playerCurrentHealth > 0)
        {
            retryLevel();
        }
    }

    private void gameOver()
    {
        //playerController.freezePlayer(true);
        ballController.freezeBall(true);
        
        defeatMenu.gameObject.SetActive(true);
        gameScore.text = this.playerActualScore.ToString();
    }

    private void retryLevel()
    {
        ballController.respawnBall();
        ballController.freezeBall(true);
        
        //playerController.respawnPlayer();
        //playerController.freezePlayer(true);
        
        startBtn.gameObject.SetActive(true);
    }

    public void retryGame()
    {
        brickCon.deleteBricks();

       // playerController.respawnPlayer();
        ballController.respawnBall();
        
        resetPlayerStats();
        
        defeatMenu.gameObject.SetActive(false);
        startBtn.gameObject.SetActive(true);
    }

    private void resetPlayerStats()
    {
        this.playerCurrentHealth = this.playerStartHealth;
        this.playerHealth.text = this.playerCurrentHealth.ToString();
        
        this.playerActualScore = 0;
        playerScore.text = playerActualScore.ToString();
    }

    public void pauseGame()
    {
        if (!gamePaused)
            ballVel = ball.velocity;
        else if (gamePaused)
            ball.velocity = ballVel;
        
        //playerController.freezePlayer(!gamePaused);
        ballController.freezeBall(!gamePaused);
        pauseMenu.SetActive(!gamePaused);
        
        this.gamePaused = !gamePaused;
    }
    */

    
}
