using UnityEngine;

namespace Spawner
{
    public class SpawnerRandomizer : MonoBehaviour
    {
        private GameObject[] currentSpawnerPoints;

        public GameObject GetRandomSpawner()
        {
            if (currentSpawnerPoints == null || currentSpawnerPoints.Length == 0)
            {
                return null;
            }

            int randomIndex = Random.Range(0, currentSpawnerPoints.Length);
            return currentSpawnerPoints[randomIndex];
        }

        public void CopySpawnerPoints(GameObject[] spawnerPoints)
        {
            currentSpawnerPoints = spawnerPoints;
        }
    }
}

