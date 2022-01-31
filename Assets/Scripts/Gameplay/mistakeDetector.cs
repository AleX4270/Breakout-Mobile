using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mistakeDetector : MonoBehaviour
{

    private GameManager gm;

    private void Start()
    {
        gm = FindObjectOfType<GameManager>();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (gm != null)
        {
            gm.takeLife(1);
        }
        else
        {
            Debug.LogError("Could not find object of type GameManager! [mistakeDetector]");
        }
    }
}
