using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    private Rigidbody2D player;
    private Touch touch;
    private Vector3 touchPosition;

    private void Start()
    {
        player = this.gameObject.GetComponent<Rigidbody2D>();
    }

    private void movePlayer(float speed)
    {
        if (Input.touchCount > 0)
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
        else if(Input.GetMouseButton(0)) //DEBUG ONLY
        {
            touchPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if (Mathf.Abs(touchPosition.y - player.position.y) <= 3)
            {
                player.MovePosition(touchPosition * speed * Time.fixedDeltaTime);
            }
        }
    }
    
}
