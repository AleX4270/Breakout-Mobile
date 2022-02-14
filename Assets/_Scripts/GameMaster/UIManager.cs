using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameController gameController;

    //Init the game's UI at the start
    internal void initGameStartingUI()
    {
        enablePasueBtn(false);
        showStartBtn(true);
        resetTopBarStatsUI();
    }

    //Adjust the game's UI after starting it
    internal void adjustGameStartedUI()
    {
        showStartBtn(false);
        enablePasueBtn(true);
    }

    internal void adjustRetryGameUI()
    {
        enablePasueBtn(true);
        showRetryBtn(false);
    }

    //When all HP is lost...
    internal void adjustGameoverUI()
    {
        enablePasueBtn(false);
        showGameOverMenu(true);
        updatePlayerScoreText();
    }

    //Attempts Management
    internal void adjustRetryAttemptUI()
    {
        enablePasueBtn(false);
        showRetryBtn(true);
    }

    internal void adjustNextLevelAttemptUI()
    {
        enablePasueBtn(false);
        showLevelCompletedMenu(true);
    }

    internal void adjustUIRestart()
    {
        enablePasueBtn(false);
        showGameOverMenu(false);
        resetTopBarStatsUI();
        showStartBtn(true);
    }

    internal void manageUINextLevel()
    {
        enablePasueBtn(false);
        showLevelCompletedMenu(false);
        resetPlayerHealthUI();
        adjustLevelNumberUI();
        showStartBtn(true);
    }

    internal void adjustPauseUI(bool wantsToDisplay)
    {
        showPauseMenu(wantsToDisplay);
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

    private void enablePasueBtn(bool isDisabled)
    {
        gameController.pauseBtn.interactable = isDisabled;
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

    private void showPauseMenu(bool isDisplayed)
    {
        gameController.pauseMenu.SetActive(isDisplayed);
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
