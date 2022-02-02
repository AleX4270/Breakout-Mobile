using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickController : MonoBehaviour
{
    [SerializeField] internal BrickData brickData;
    [SerializeField] internal BrickManager brickManager;

    [SerializeField] internal GameObject brickPrefab;
    [SerializeField] internal Camera mainCam;
    [SerializeField] internal Transform spawnPoint;

    internal float brickWidth;
    internal float cameraWidth;
    internal int maxBricks;

    internal GameObject[] bricksInstances;

    private void Start()
    {
        this.brickWidth = brickPrefab.GetComponent<SpriteRenderer>().bounds.size.x;

        this.cameraWidth = (mainCam.orthographicSize * 2) * mainCam.aspect;
        this.cameraWidth -= brickData.boundOffset;

        this.maxBricks = (int)(this.cameraWidth / this.brickWidth);

        this.bricksInstances = new GameObject[maxBricks];

        brickData.brickOffset = ((this.cameraWidth / this.brickWidth) - this.maxBricks) / this.maxBricks;

        Debug.Log("Max Bricks: " + maxBricks);
        Debug.Log("Max Bricks (float): " + (cameraWidth / brickWidth));
        Debug.Log("Offset: " + brickData.brickOffset);
        Debug.Log("Cam width: " + cameraWidth);
        Debug.Log("Brick width: " + brickWidth);
    }
}
