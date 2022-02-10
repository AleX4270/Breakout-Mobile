using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatsManager : MonoBehaviour
{
    [SerializeField] private GameController gameController;

    //Player Stats Management
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

    public void resetPlayerHealthStats()
    {
        gameController.playerController.playerData.currentHealth = gameController.playerController.playerData.startHealth;
    }

    public void resetPlayerScoreStats()
    {
        gameController.playerController.playerData.currentScore = 0;
    }

    public void restartStats()
    {
        resetPlayerHealthStats();
        resetPlayerScoreStats();
    }

    public void resetNextLevelStats()
    {
        resetPlayerHealthStats();
    }
}
