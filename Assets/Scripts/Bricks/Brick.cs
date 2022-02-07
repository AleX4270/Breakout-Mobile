using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    private GameController controller;

    private void Awake()
    {
        controller = FindObjectOfType<GameController>();
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Ball"))
        {
            controller.playerStatsManager.addPoints(1);
            Destroy(this.gameObject);
        }
    }
}
