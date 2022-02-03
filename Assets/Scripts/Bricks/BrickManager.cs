using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickManager : MonoBehaviour
{
    [SerializeField] private BrickController controller;

    public void spawnBricksRow()
    {
        for (int k = 0; k < controller.maxBricks; k++)
        {
            if (k == 0)
            {
                controller.bricksInstances[k] = Instantiate(controller.brickPrefab, controller.spawnPoint.position
                        + new Vector3(controller.brickWidth / 2 + controller.brickData.boundOffset / 2, 0, 0),
                        Quaternion.identity);
            }
            else
            {
                controller.bricksInstances[k] = Instantiate(controller.brickPrefab,
                         controller.bricksInstances[k - 1].transform.position + new Vector3(controller.brickWidth
                         + controller.brickData.brickOffset, 0, 0),
                         Quaternion.identity);
            }
        }
    }

    public void deleteBrick(GameObject target)
    {
        Destroy(target);
    }

    public void deleteBricksRow()
    {
        foreach(var brick in controller.bricksInstances)
        {
            Destroy(brick);
        }
    }
}
