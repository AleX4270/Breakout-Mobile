using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameController gameController;

    //Init the game's UI at the start
    internal void initGameStartingUI()
    {
        showStartBtn(true);
        resetTopBarStatsUI();
    }

    //Adjust the game's UI after starting it
    internal void adjustGameStartedUI()
    {
        showStartBtn(false);
    }

    internal void adjustRetryGameUI()
    {
        showRetryBtn(false);
    }

    //When all HP is lost...
    internal void adjustGameoverUI()
    {
        showGameOverMenu(true);
        updatePlayerScoreText();
    }

    //Attempts Management
    internal void adjustRetryAttemptUI()
    {
        showRetryBtn(true);
    }

    internal void adjustNextLevelAttemptUI()
    {
        showLevelCompletedMenu(true);
    }

    internal void adjustUIRestart()
    {
        showGameOverMenu(false);
        resetTopBarStatsUI();
        showStartBtn(true);
    }

    internal void manageUINextLevel()
    {
        showLevelCompletedMenu(false);
        resetPlayerHealthUI();
        adjustLevelNumberUI();
        showStartBtn(true);
    }

    //Updates
    internal void updatePlayerHealthText()
    {
        gameController.playerHealth.text = gameController.playerController.playerData.currentHealth.ToString();
    }

    internal void updatePlayerScoreText()
    {
        gameController.playerScore.text = gameController.playerController.playerData.currentScore.ToString();
    }

    //Buttons Management
    private void showStartBtn(bool isDisplayed)
    {
        gameController.startBtn.gameObject.SetActive(isDisplayed);
    }

    private void showRetryBtn(bool isDisplayed)
    {
        gameController.retryBtn.gameObject.SetActive(isDisplayed);
    }

    //Menus Management
    private void showGameOverMenu(bool isDisplayed)
    {
        gameController.gameOverMenu.SetActive(isDisplayed);
    }

    private void showLevelCompletedMenu(bool isDisplayed)
    {
        gameController.completeMenu.SetActive(isDisplayed);
    }

    //UI Stats Management
    private void resetTopBarStatsUI()
    {
        resetPlayerHealthUI();
        resetPlayerCurrentScoreUI();
        adjustLevelNumberUI();
    }

    private void resetPlayerHealthUI()
    {
        gameController.playerHealth.text = gameController.playerController.playerData.startHealth.ToString();
    }

    private void resetPlayerCurrentScoreUI()
    {
        gameController.playerScore.text = "0";
    }

    private void adjustLevelNumberUI()
    {
        gameController.gameLevel.text = gameController.levelData.currentLevel.ToString();
    }
}
