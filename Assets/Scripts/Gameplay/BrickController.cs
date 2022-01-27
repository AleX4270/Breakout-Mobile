using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickController : MonoBehaviour
{
    public GameObject brickPrefab;
    public Camera mainCam;
    private float brickOffset;
    private GameObject previousBrick;
    public float boundOffset;

    [Header("Spawnpoints")] 
    public Transform[] spawnPoints;
   
    
    private float brickWidth;
    private float cameraWidth;
    private int maxBricks;

    private void Start()
    {
        brickWidth = brickPrefab.GetComponent<SpriteRenderer>().bounds.size.x;
        cameraWidth = mainCam.orthographicSize * mainCam.aspect;
        cameraWidth *= 2f;
        cameraWidth -= boundOffset;

        maxBricks = (int)(cameraWidth / brickWidth);

        brickOffset = ((cameraWidth / brickWidth) - maxBricks) / maxBricks;
        
        spawnBricks(); //should be called by GameManager
    }

    private void spawnBricks()
    {
        Debug.Log("Max Bricks: " + maxBricks);
        Debug.Log("Max Bricks (float): " + (cameraWidth / brickWidth));
        Debug.Log("Offset: " + brickOffset);
        Debug.Log("Cam width: " + cameraWidth);
        Debug.Log("Brick width: " + brickWidth);
        Debug.Log(mainCam.orthographicSize);
        Debug.Log(spawnPoints.Length);
        
        
        if (maxBricks > 0)
        {

            for (int j = 0; j < spawnPoints.Length; j++)
            {
                spawnPoints[j].transform.position = spawnPoints[j].transform.position + new Vector3(brickWidth/2 + boundOffset/2, 0, 0);
            }
            
            for (int i = 0; i < spawnPoints.Length; i++)
            {
                for (int k = 0; k < maxBricks; k++)
                {
                    if (k == 0)
                    {
                        previousBrick = Instantiate(brickPrefab, spawnPoints[i].transform.position, 
                            Quaternion.identity);
                    }
                    else
                    {
                        previousBrick =  Instantiate(brickPrefab, previousBrick.transform.position + new Vector3(brickWidth + brickOffset, 0, 0), 
                            Quaternion.identity);
                    }
                }
                
            }
            
        }
        
    }

    public void deleteBricks()
    {
        
    }
}
