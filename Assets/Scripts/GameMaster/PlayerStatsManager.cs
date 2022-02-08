using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatsManager : MonoBehaviour
{
    [SerializeField] private GameController gameController;

    //Init player stats (reset)
    public void restartStats()
    {
        resetPlayerHealthStats();
        resetPlayerScoreStats();
    }

    //Reset the stats for the next level
    public void resetNextLevelStats()
    {
        resetPlayerHealthStats();
    }

    //Player Stats Management
    public void resetPlayerHealthStats()
    {
        gameController.playerController.playerData.currentHealth = gameController.playerController.playerData.startHealth;
    }

    public void resetPlayerScoreStats()
    {
        gameController.playerController.playerData.currentScore = 0;
    }

    public void takeLife(int amount)
    {
        gameController.playerController.playerData.currentHealth -= amount;
        gameController.uiManager.updatePlayerHealthText();
        Debug.Log("Health: " + gameController.playerController.playerData.currentHealth);

        if(gameController.playerController.playerData.currentHealth <= 0)
        {
            gameController.gameManager.gameOver();
        }
        else
        {
            gameController.gameManager.retryAttempt();
        }
    }

    public void addPoints(int amount)
    {
        gameController.playerController.playerData.currentScore += amount;
        gameController.uiManager.updatePlayerScoreText();
    }
}
