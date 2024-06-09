using UnityEngine;

[CreateAssetMenu(fileName = "NewBerry", menuName = "Berry")]
public class Berry : ScriptableObject
{
    [SerializeField] public new string name;
    [SerializeField] public Sprite sprite;
    [SerializeField][Range (1, 3)] public int pointValue = 1;
    [SerializeField][Range(1, 10)] public int spawnFrequency = 10;
}
