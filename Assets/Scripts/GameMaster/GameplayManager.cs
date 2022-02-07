using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayManager : MonoBehaviour
{
    [SerializeField] private GameController gameController;

    //Init
    public void initGameScene()
    {
        pauseGame();
    }

    //Game State Management
    public void startGame()
    {
        generateBricks();
        resumeGame();

        gameController.ballController.ballMovement.pushBall();
    }

    public void continueGame()
    {
        resumeGame();
        gameController.ballController.ballMovement.pushBall();

        gameController.uiManager.showRetryBtn(false);
    }

    public void restartGame()
    {
        deleteBricks();

        respawnPlayerAndBall();

        pauseGame();
    }

    public void retryAttempt()
    {
        respawnPlayerAndBall();

        pauseGame();

        gameController.uiManager.showRetryBtn(true);
    }

    public void pauseGame()
    {
        gameController.gameState.changeGameState(true);
    }

    public void resumeGame()
    {
        gameController.gameState.changeGameState(false);
    }

    public void gameOver()
    {
        pauseGame();
        gameController.uiManager.showGameOverMenu(true);
        gameController.uiManager.updateGameOverPlayerStats();
    }

    //Misc.

    public void generateBricks()
    {
        foreach (var row in gameController.brickControllers)
        {
            row.brickManager.spawnBricksRow();
        }
    }

    public void deleteBricks()
    {
        foreach(var row in gameController.brickControllers)
        {
            row.brickManager.deleteBricksRow();
        }
    }

    public void respawnPlayerAndBall()
    {
        gameController.ballController.ballMovement.respawnBall();
        gameController.playerController.playerMovement.respawnPlayer();
    }
}
