using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "BallData")]
public class BallData : ScriptableObject
{
    [Header("Gameplay Controls")]
    public float speed;
    public float bounceOffset;
}
