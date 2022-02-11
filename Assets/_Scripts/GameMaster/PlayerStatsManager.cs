using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatsManager : MonoBehaviour
{
    [SerializeField] private GameController gameController;

    //Player Stats Management
    internal void takeLife(int amount)
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

    internal void addPoints(int amount)
    {
        gameController.playerController.playerData.currentScore += amount;
        gameController.uiManager.updatePlayerScoreText();
    }

    private void resetPlayerHealthStats()
    {
        gameController.playerController.playerData.currentHealth = gameController.playerController.playerData.startHealth;
    }

    private void resetPlayerScoreStats()
    {
        gameController.playerController.playerData.currentScore = 0;
    }

    internal void restartStats()
    {
        resetPlayerHealthStats();
        resetPlayerScoreStats();
    }

    internal void resetNextLevelStats()
    {
        resetPlayerHealthStats();
    }
}
