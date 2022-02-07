using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameController gameController;

    //States
    public void initGameStartingUI()
    {
        showStartBtn(true);
        resetPlayerStatsUI();
    }
    
    public void startGame()
    {
        showStartBtn(false);
    }

    public void manageUIContinueState()
    {
        showRetryBtn(false);
    }

    public void manageUIRestartState()
    {
        showGameOverMenu(false);
        resetPlayerStatsUI();
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

    //Misc.
    public void resetPlayerStatsUI()
    {
        gameController.playerScore.text = "0";
        gameController.playerHealth.text = gameController.playerController.playerData.startHealth.ToString();
    }
}
