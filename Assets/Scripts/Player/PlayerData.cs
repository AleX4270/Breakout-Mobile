using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "PlayerData")]
public class PlayerData : ScriptableObject
{
    public float speed;
    public float offset;

    public float Speed
    {
        get { return speed; }
    }

    public float Offset
    {
        get { return offset; }
    }
}
