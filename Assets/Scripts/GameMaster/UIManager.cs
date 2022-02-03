using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameController gameController;

    //Init
    public void initGameStartingUI()
    {
        showStartBtn();
        resetPlayerStatsUI();
    }

    //Start
    public void startGame()
    {
        hideStartBtn();
    }

    public void showStartBtn()
    {
        gameController.startBtn.gameObject.SetActive(true);
    }

    public void hideStartBtn()
    {
        gameController.startBtn.gameObject.SetActive(false);
    }

    public void resetPlayerStatsUI()
    {
        gameController.playerScore.text = "0";
        gameController.playerHealth.text = gameController.playerController.playerData.startHealth.ToString();
    }
}
