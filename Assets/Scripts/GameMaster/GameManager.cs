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

    //Init
    public void initGame()
    {
        gameController.gameplayManager.initGameScene();
        gameController.playerStatsManager.initStartingStats();
        gameController.uiManager.initGameStartingUI();
    }

    //Start
    public void startGame()
    {
        gameController.uiManager.startGame();
        gameController.gameplayManager.startGame();
    }
}
