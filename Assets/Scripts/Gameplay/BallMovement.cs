using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class BallMovement : MonoBehaviour
{
    private float x, xDir;
    private Vector2 bounceDir;
    private GameManager gm;

    [Range(0.1f, 1f)]
    public float bounceOffset;
    
    public float speed;
    private Rigidbody2D ball;
    public Transform ballSpawn;
    
    private void Start()
    {
        ball = this.gameObject.GetComponent<Rigidbody2D>();
        gm = FindObjectOfType<GameManager>();
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            Vibration.Vibrate(20);

            bounceDir = (col.GetContact(0).point - (Vector2) col.gameObject.transform.position).normalized;
            bounceDir.x = Mathf.Clamp(bounceDir.x, -bounceOffset, bounceOffset);


            ball.velocity = Vector2.zero;
            ball.AddForce(new Vector2(bounceDir.x, 0.5f).normalized * this.speed * 100);
            Debug.Log("Kierunek: " + bounceDir.x);
            Debug.DrawLine(col.gameObject.transform.position, col.GetContact(0).point, Color.green);
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        //If ball hit the brick
        if(other.gameObject.CompareTag("Brick"))
        {
            Destroy(other.gameObject);
            gm.addPoint();
        }
    }

    public void pushBall()
    {
        float x = Random.Range(-bounceOffset, bounceOffset);
        
        ball.AddForce(new Vector2(x, 0.5f).normalized * this.speed * 100);
    }

    public void freezeBall(bool freeze)
    {
        if (freeze)
        {
            ball.constraints = RigidbodyConstraints2D.FreezeAll;
        }
        else
        {
            ball.constraints = RigidbodyConstraints2D.FreezeRotation;
        }
    }
}
