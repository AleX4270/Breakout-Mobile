using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D player;
    private bool freeze;
    public float speed;
    public Transform playerSpawnpoint;
    public Camera mainCam;
    private Touch touch;

    private Vector3 touchPosition;
    private Vector2 playerPos;

    private void Start()
    {
        player = this.gameObject.GetComponent<Rigidbody2D>();
        this.freeze = true;
    }

    private void FixedUpdate()
    {
        movePlayer();
    }

    private void movePlayer()
    {
        if (Input.touchCount > 0 && !freeze)
        {
            touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                touchPosition = Camera.main.ScreenToWorldPoint(touch.position);

                if (Mathf.Abs(touchPosition.y - player.position.y) <= 3)
                {
                    player.MovePosition(touchPosition * speed * Time.fixedDeltaTime);
                }
            }
        }
        else if(Input.GetMouseButton(0) && !freeze) //DEBUG ONLY - DELETE WHEN BUILDING
        {
            touchPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if (Mathf.Abs(touchPosition.y - player.position.y) <= 3)
            {
                player.MovePosition(touchPosition * speed * Time.fixedDeltaTime);
            }
        }
    }
    

    public void respawnPlayer()
    {
        this.transform.position = playerSpawnpoint.position;
    }

    public void freezePlayer(bool freeze)
    {
        this.freeze = freeze;
    }
}
