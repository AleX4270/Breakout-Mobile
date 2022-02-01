using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class BallMovement : MonoBehaviour
{
    [SerializeField] private BallController ballController;
    private float randX;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            ballController.ballPhys.calculateBouncePlayer(collision);
        }
        
        if(collision.gameObject.CompareTag("Wall"))
        {
            ballController.ballPhys.calculateBounceWall(collision);
        }
    }
    
    public void pushBall(float randOffset)
    {
        randX = Random.Range(-randOffset, randOffset);
        ballController.rb2d.velocity = new Vector2(randX, 1f).normalized * ballController.ballData.speed * 100 * Time.deltaTime;
    }

    public void respawnBall()
    {
        this.transform.position = ballController.respawnPoint.position;
    }
}
