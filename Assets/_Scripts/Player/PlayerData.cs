using UnityEngine;

[CreateAssetMenu(menuName = "PlayerData")]
public class PlayerData : ScriptableObject
{
    public float speed;
    public float offset;
    public float startHealth;

    internal float currentHealth;
    internal float currentScore;
}
