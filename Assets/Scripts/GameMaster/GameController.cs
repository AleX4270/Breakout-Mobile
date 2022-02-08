using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [SerializeField] internal GameplayManager gameplayManager;
    [SerializeField] internal GameManager gameManager;
    [SerializeField] internal UIManager uiManager;
    [SerializeField] internal GameState gameState;
    [SerializeField] internal PlayerStatsManager playerStatsManager;
    [SerializeField] internal LevelManager levelManager;

    [SerializeField] internal BallController ballController;
    [SerializeField] internal PlayerController playerController;
    [SerializeField] internal BrickController[] brickControllers;

    [SerializeField] internal LevelData levelData;

    [Header("UI")]
    [SerializeField] internal Button startBtn;
    [SerializeField] internal Button retryBtn;
    [SerializeField] internal TMP_Text playerScore;
    [SerializeField] internal TMP_Text playerHealth;
    [SerializeField] internal TMP_Text gameLevel;
    [SerializeField] internal GameObject gameOverMenu;
    [SerializeField] internal GameObject completeMenu;

    [Header("Game Over Menu")]
    [SerializeField] internal TMP_Text gameScore;

    internal float bricksCount;

}
