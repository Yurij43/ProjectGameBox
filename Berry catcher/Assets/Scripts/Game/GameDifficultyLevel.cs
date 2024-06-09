using Spawner;
using UnityEngine;

namespace Game
{
    public class GameDifficultyLevel : MonoBehaviour
    {
        [Header("Difficulty level vars")]
        [SerializeField] private float timeCycleDifficultyChanges;
        [SerializeField][Range(1, 5)] private int spawnPointIncreaseValue;
        [SerializeField][Range(0, 1)] private float berrySammonTimeCoefficient;
        [SerializeField][Range(0, 1)] private float fallBerrySpeedCoefficient;

        [Header("Settings")]
        [SerializeField] private SpawnerBerriesPositionPoints spawnerBerriesPositionPoints;
        [SerializeField] private SummonBerries summonBerries;
        [SerializeField] private Rigidbody2D berryRb;

        private float nextTime;

        private void Start()
        {
            nextTime = timeCycleDifficultyChanges;
            berryRb.drag = 5;
        }

        private void Update()
        {
            if (Time.time >= nextTime)
            {
                nextTime = Time.time + timeCycleDifficultyChanges;
                ChangeDifficultyLevel();
            }
        }

        private void ChangeDifficultyLevel()
        {
            spawnerBerriesPositionPoints.ChangeQuantitySpawnerPoints(spawnPointIncreaseValue);
            summonBerries.ChangeTimeSummon(berrySammonTimeCoefficient);
            berryRb.drag *= fallBerrySpeedCoefficient;
        }

    }
}

