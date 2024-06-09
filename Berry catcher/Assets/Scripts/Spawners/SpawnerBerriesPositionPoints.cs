using GlobalVars;
using UnityEngine;

namespace Spawner
{
    public class SpawnerBerriesPositionPoints : MonoBehaviour
    {
        [Header("Spawn vars")]
        [SerializeField] private int quantitySpawnerPoints;

        [Header("Settings")]      
        [SerializeField] private Transform leftPosition;
        [SerializeField] private Transform rightPosition;
        [SerializeField] private SpawnerRandomizer spawnerRandomizer;

        private GameObject[] spawnerPoints;
        private float spawnerWidth;

        private void Awake()
        {
            spawnerWidth = rightPosition.position.x - leftPosition.position.x;
            SetSpawerPosition(quantitySpawnerPoints);
        }

        public void SetSpawerPosition(int quantitySpawnerPoints)
        {
            ClearSpawnerPoints();

            spawnerPoints = new GameObject[quantitySpawnerPoints];
            float widthBetweenSpawnPoints = spawnerWidth / (quantitySpawnerPoints + 1);
            float spawnerPosition = leftPosition.position.x;

            for (int i = 0; i < spawnerPoints.Length; i++)
            {
                GameObject point = new GameObject(GlobalStringVars.NameSpawnerPoint + i);
                spawnerPosition += widthBetweenSpawnPoints;
                point.transform.position = new Vector2(spawnerPosition, transform.position.y);
                point.transform.parent = transform;
                spawnerPoints[i] = point;
            }

            spawnerRandomizer?.CopySpawnerPoints(spawnerPoints);
        }

        public void ChangeQuantitySpawnerPoints(int increaseValue)
        {
            quantitySpawnerPoints += increaseValue;
            SetSpawerPosition(quantitySpawnerPoints);
        }

        private void ClearSpawnerPoints()
        {
            if (spawnerPoints != null)
            {
                foreach (GameObject point in spawnerPoints)
                {
                    Destroy(point);
                }
            }
        }
    }
}

