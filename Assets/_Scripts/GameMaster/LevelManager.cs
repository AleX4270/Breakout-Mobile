using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private GameController gameController;

    //Init the game level code.
    internal void resetGameLevel()
    {
        gameController.levelData.currentLevel = gameController.levelData.startingLevel;
    }

    internal void nextLevel()
    {
        gameController.levelData.currentLevel++;
    }
}
