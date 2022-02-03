using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayManager : MonoBehaviour
{
    [SerializeField] private GameController gameController;

    public void initGameScene()
    {
        pauseGame();
    }

    public void startGame()
    {
        generateBricks();
        resumeGame();

        gameController.ballController.ballMovement.pushBall();
    }

    public void generateBricks()
    {
        foreach(var row in gameController.brickControllers)
        {
            row.brickManager.spawnBricksRow();
        }
    }

    public void pauseGame()
    {
        gameController.gameState.changeGameState(true);
    }

    public void resumeGame()
    {
        gameController.gameState.changeGameState(false);
    }
}
