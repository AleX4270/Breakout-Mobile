using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayManager : MonoBehaviour
{
    [SerializeField] private GameController gameController;

    //Initialize the game scene
    internal void initGameScene()
    {
        pauseGame();
    }

    //Start the game after pressing the start btn
    internal void startGame()
    {
        generateBricks();
        resumeGame();

        pushTheBall();
    }

    //Retry the game after failure
    internal void retryGame()
    {
        resumeGame();
        pushTheBall();
    }

    //Restart the game after a total failure
    internal void restartGame()
    {
        respawnPlayerAndBall();
        pauseGame();

        deleteBricks();
    }

    //Prepare the next level
    internal void nextLevel()
    {
        respawnPlayerAndBall();
        pauseGame();
    }

    //An attempt to retry or restart the game
    internal void adjustAttempt()
    {
        respawnPlayerAndBall();
        pauseGame();
    }


    //Gameplay State Management
    internal void pauseGame()
    {
        gameController.gameState.changeGameState(true);
    }

    internal void resumeGame()
    {
        gameController.gameState.changeGameState(false);
    }

    //Bricks management

    private void generateBricks()
    {
        foreach (var row in gameController.brickControllers)
        {
            row.brickManager.spawnBricksRow();
            gameController.bricksCount += row.maxBricks;
        }
    }

    private void deleteBricks()
    {
        foreach(var row in gameController.brickControllers)
        {
            row.brickManager.deleteBricksRow();
        }
    }

    internal void subtractBrickCount(int amount)
    {
        gameController.bricksCount -= amount;
        Debug.Log(gameController.bricksCount);

        if (gameController.bricksCount <= 0)
        {
            gameController.gameManager.nextLevelAttempt();
        }
    }

    //Player and ball Management
    internal void respawnPlayerAndBall()
    {
        gameController.ballController.ballMovement.respawnBall();
        gameController.playerController.playerMovement.respawnPlayer();
    }

    internal void pushTheBall()
    {
        gameController.ballController.ballMovement.pushBall();
    }
}
