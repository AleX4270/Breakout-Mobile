using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "GMData")]
public class GameManagerData : ScriptableObject
{
    public bool isNormalMode;
    public bool isArcadeMode;
    public bool isMenu;
}
