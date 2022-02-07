using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatsManager : MonoBehaviour
{
    [SerializeField] private GameController gameController;

    //States
    public void initStartingStats()
    {
        resetPlayerStats();
    }

    //Player Stats Management
    public void resetPlayerStats()
    {
        gameController.playerController.playerData.currentHealth = gameController.playerController.playerData.startHealth;
        gameController.playerController.playerData.currentScore = 0;
    }

    public void takeLife(int amount)
    {
        gameController.playerController.playerData.currentHealth -= amount;
        gameController.uiManager.updatePlayerHealthText();
        Debug.Log("Health: " + gameController.playerController.playerData.currentHealth);

        if(gameController.playerController.playerData.currentHealth <= 0)
        {
            gameController.gameplayManager.gameOver();
        }
        else
        {
            gameController.gameplayManager.retryAttempt();
        }
    }

    public void addPoints(int amount)
    {
        gameController.playerController.playerData.currentScore += amount;
        gameController.uiManager.updatePlayerScoreText();
    }
}
