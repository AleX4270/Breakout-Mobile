using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPhysics : MonoBehaviour
{
    private Rigidbody2D rb2d;

    private void Start()
    {
        this.rb2d = GetComponent<Rigidbody2D>();
    }

    public void movePlayer(Vector3 newPosition, float speed, float offset, PState playerState)
    {
        if((Mathf.Abs(newPosition.y - rb2d.position.y) < offset) && (playerState == PState.inGame))
        {
            this.rb2d.MovePosition(newPosition * speed * Time.fixedDeltaTime);
        }
    }

    public void respawnPlayer(Transform playerSpawnpoint)
    {
        this.transform.position = playerSpawnpoint.position;
    }
}
