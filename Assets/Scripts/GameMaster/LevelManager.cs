using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private GameController gameController;

    //Init the game level code.
    public void resetGameLevel()
    {
        gameController.levelData.currentLevel = gameController.levelData.startingLevel;
    }

    public void nextLevel()
    {
        gameController.levelData.currentLevel++;
    }
}
