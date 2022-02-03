using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [SerializeField] internal GameplayManager gameplayManager;
    [SerializeField] internal UIManager uiManager;
    [SerializeField] internal GameState gameState;
    [SerializeField] internal PlayerStatsManager playerStatsManager;

    [SerializeField] internal BallController ballController;
    [SerializeField] internal PlayerController playerController;
    [SerializeField] internal BrickController[] brickControllers;

    [Header("UI")]
    [SerializeField] internal Button startBtn;
    [SerializeField] internal TMP_Text playerScore;
    [SerializeField] internal TMP_Text playerHealth;
}
