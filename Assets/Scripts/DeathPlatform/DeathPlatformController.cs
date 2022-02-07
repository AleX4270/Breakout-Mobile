using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathPlatformController : MonoBehaviour
{
    [SerializeField] internal GameController gameController;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Ball"))
        {
            gameController.playerStatsManager.takeLife(1);
            Debug.Log("Hit!", this);
        }
    }
}
