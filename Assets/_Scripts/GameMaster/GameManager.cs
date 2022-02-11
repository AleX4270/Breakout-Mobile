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
        if (!gameController.isGameplay) return;

        gameController.gameplayManager.initGameScene();
        gameController.playerStatsManager.restartStats();
        gameController.levelManager.resetGameLevel();
        gameController.uiManager.initGameStartingUI();
    }

    //Start the game after pressing the start btn
    public void startGame()
    {
        if (!gameController.isGameplay) return;

        gameController.uiManager.adjustGameStartedUI();
        gameController.gameplayManager.startGame();
    }

    //Retry after a failure
    public void retryGame()
    {
        if (!gameController.isGameplay) return;

        gameController.uiManager.adjustRetryGameUI();
        gameController.gameplayManager.retryGame();
    }

    //Restart the game after a failure
    public void restartGame()
    {
        if (!gameController.isGameplay) return;

        gameController.playerStatsManager.restartStats();
        gameController.levelManager.resetGameLevel();
        gameController.uiManager.adjustUIRestart();
        gameController.gameplayManager.restartGame();
    }

    //Load next level after finishing the previous one
    public void nextLevel()
    {
        if (!gameController.isGameplay) return;

        gameController.playerStatsManager.resetNextLevelStats();
        gameController.levelManager.nextLevel();
        gameController.uiManager.manageUINextLevel();
        gameController.gameplayManager.nextLevel();
    }

    //When all HP is lost...
    public void gameOver()
    {
        if (!gameController.isGameplay) return;

        gameController.uiManager.adjustGameoverUI();
        gameController.gameplayManager.pauseGame();
    }

    //Attempts
    public void retryAttempt()
    {
        if (!gameController.isGameplay) return;

        gameController.gameplayManager.adjustAttempt();
        gameController.uiManager.adjustRetryAttemptUI();
    }

    public void nextLevelAttempt()
    {
        if (!gameController.isGameplay) return;

        gameController.gameplayManager.adjustAttempt();
        gameController.uiManager.adjustNextLevelAttemptUI();
    }

}
