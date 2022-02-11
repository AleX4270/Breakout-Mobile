using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "DataPacks/LevelData")]
public class LevelData : ScriptableObject
{
    public int startingLevel;

    internal int currentLevel;
}
