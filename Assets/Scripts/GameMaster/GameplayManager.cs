using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayManager : MonoBehaviour
{
    [SerializeField] private GameController gameController;

    //Initialize the game scene
    public void initGameScene()
    {
        pauseGame();
    }

    //Start the game after pressing the start btn
    public void startGame()
    {
        generateBricks();
        resumeGame();

        pushTheBall();
    }

    //Retry the game after failure
    public void retryGame()
    {
        resumeGame();
        pushTheBall();
    }

    //Restart the game after a total failure
    public void restartGame()
    {
        respawnPlayerAndBall();
        pauseGame();

        deleteBricks();
    }

    //Prepare the next level
    public void nextLevel()
    {
        respawnPlayerAndBall();
        pauseGame();
    }

    //Attempts
    public void adjustAttempt()
    {
        respawnPlayerAndBall();
        pauseGame();
    }


    //Game State Management
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
    }

    //Misc.

    public void generateBricks()
    {
        foreach (var row in gameController.brickControllers)
        {
            row.brickManager.spawnBricksRow();
            gameController.bricksCount += row.maxBricks;
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

    public void subtractBrickCount(int amount)
    {
        gameController.bricksCount -= amount;
        Debug.Log(gameController.bricksCount);

        if(gameController.bricksCount <= 0)
        {
            gameController.gameManager.nextLevelAttempt();
        }
    }

    public void pushTheBall()
    {
        gameController.ballController.ballMovement.pushBall();
    }
}