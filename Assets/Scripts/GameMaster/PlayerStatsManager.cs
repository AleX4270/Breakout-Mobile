using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatsManager : MonoBehaviour
{
    [SerializeField] private GameController gameController;

    public void initStartingStats()
    {
        resetPlayerStats();
    }

    public void resetPlayerStats()
    {
        gameController.playerController.playerData.currentHealth = gameController.playerController.playerData.startHealth;
        gameController.playerController.playerData.currentScore = 0;
    }
}
