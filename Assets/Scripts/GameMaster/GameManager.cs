using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameController gameController;

    private void Start()
    {
        initGame();
    }

    //Initialize the level for the first time
    public void initGame()
    {
        gameController.gameplayManager.initGameScene();
        gameController.playerStatsManager.restartStats();
        gameController.levelManager.resetGameLevel();
        gameController.uiManager.initGameStartingUI();
    }

    //Start the game after pressing the start btn
    public void startGame()
    {
        gameController.uiManager.adjustGameStartedUI();
        gameController.gameplayManager.startGame();
    }

    //Retry after a failure
    public void retryGame()
    {
        gameController.uiManager.adjustRetryGameUI();
        gameController.gameplayManager.retryGame();
    }

    //Restart the game after a failure
    public void restartGame()
    {
        gameController.playerStatsManager.restartStats();
        gameController.levelManager.resetGameLevel();
        gameController.uiManager.manageUIRestartState();
        gameController.gameplayManager.restartGame();
    }

    //Load next level after finishing the previous one
    public void nextLevel()
    {
        gameController.playerStatsManager.resetNextLevelStats();
        gameController.levelManager.nextLevel();
        gameController.uiManager.manageUINextLevelState();
        gameController.gameplayManager.nextLevel();
    }

    //When all HP is lost...
    public void gameOver()
    {
        gameController.uiManager.adjustGameoverUI();
        gameController.gameplayManager.gameOver();
    }

    //Attempts
    public void retryAttempt()
    {
        gameController.gameplayManager.adjustAttempt();
        gameController.uiManager.adjustRetryAttemptUI();
    }

    public void nextLevelAttempt()
    {
        gameController.gameplayManager.adjustAttempt();
        gameController.uiManager.adjustNextLevelAttemptUI();
    }

}
