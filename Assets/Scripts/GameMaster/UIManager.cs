using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameController gameController;

    //Init the game's UI at the start
    public void initGameStartingUI()
    {
        showStartBtn(true);
        resetTopBarStatsUI();
    }
    
    //Adjust the game's UI after starting it
    public void adjustGameStartedUI()
    {
        showStartBtn(false);
    }

    public void adjustRetryGameUI()
    {
        showRetryBtn(false);
    }

    //When all HP is lost...
    public void adjustGameoverUI()
    {
        showGameOverMenu(true);
        updateGameOverPlayerStats();
    }

    //Attempts Management
    public void adjustRetryAttemptUI()
    {
        showRetryBtn(true);
    }

    public void adjustNextLevelAttemptUI()
    {
        showLevelCompletedMenu(true);
    }

    public void manageUIRestartState()
    {
        showGameOverMenu(false);
        resetTopBarStatsUI();
        showStartBtn(true);
    }

    public void manageUINextLevelState()
    {
        showLevelCompletedMenu(false);
        resetPlayerHealthUI();
        adjustLevelNumberUI();
        showStartBtn(true);
    }

    //Updates
    public void updatePlayerHealthText()
    {
        gameController.playerHealth.text = gameController.playerController.playerData.currentHealth.ToString();
    }

    public void updatePlayerScoreText()
    {
        gameController.playerScore.text = gameController.playerController.playerData.currentScore.ToString();
    }

    public void updateGameOverPlayerStats()
    {
        gameController.gameScore.text = gameController.playerController.playerData.currentScore.ToString();
        //Update high score
    }

    //Buttons Management
    public void showStartBtn(bool isDisplayed)
    {
        gameController.startBtn.gameObject.SetActive(isDisplayed);
    }

    public void showRetryBtn(bool isDisplayed)
    {
        gameController.retryBtn.gameObject.SetActive(isDisplayed);
    }

    //Menus Management
    public void showGameOverMenu(bool isDisplayed)
    {
        gameController.gameOverMenu.SetActive(isDisplayed);
    }

    public void showLevelCompletedMenu(bool isDisplayed)
    {
        gameController.completeMenu.SetActive(isDisplayed);
    }

    //Misc.
    public void resetTopBarStatsUI()
    {
        resetPlayerHealthUI();
        resetPlayerCurrentScoreUI();
        adjustLevelNumberUI();
    }

    
    //UI Stats Management
    public void resetPlayerHealthUI()
    {
        gameController.playerHealth.text = gameController.playerController.playerData.startHealth.ToString();
    }

    public void resetPlayerCurrentScoreUI()
    {
        gameController.playerScore.text = "0";
    }

    public void adjustLevelNumberUI()
    {
        gameController.gameLevel.text = gameController.levelData.currentLevel.ToString();
    }
}
