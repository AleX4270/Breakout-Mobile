using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [Header("Mode")]
    [SerializeField] internal bool isGameplay;
    [SerializeField] internal bool isMenu;
    
    [Header("Managers")]
    [SerializeField] internal LevelController levelController;
    [SerializeField] internal GameplayManager gameplayManager;
    [SerializeField] internal GameManager gameManager;
    [SerializeField] internal UIManager uiManager;
    [SerializeField] internal GameState gameState;
    [SerializeField] internal PlayerStatsManager playerStatsManager;
    [SerializeField] internal LevelManager levelManager;
    
    [Header("Data")]
    [SerializeField] internal LevelData levelData;
    [SerializeField] internal GameManagerData gameManagerData;

    [Header("GameplayObjects")]
    [SerializeField] internal BallController ballController;
    [SerializeField] internal PlayerController playerController;
    [SerializeField] internal BrickController[] brickControllers;

    [Header("UI")]
    [SerializeField] internal Button startBtn;
    [SerializeField] internal Button retryBtn;

    [Header("UI Top Bar Stats")]
    [SerializeField] internal TMP_Text playerScore;
    [SerializeField] internal TMP_Text playerHealth;
    [SerializeField] internal TMP_Text gameLevel;

    [Header("UI Game Over Menu")]
    [SerializeField] internal GameObject gameOverMenu;
    [SerializeField] internal TMP_Text gameScore;

    [Header("UI Finish Menu")]
    [SerializeField] internal GameObject completeMenu;

    [Header("UI Pause Menu")]
    [SerializeField] internal GameObject pauseMenu;
    [SerializeField] internal Button pauseBtn;

    //Internal Controls
    internal float bricksCount;
}
