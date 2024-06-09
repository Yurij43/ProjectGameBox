using Berries;
using System.Collections;
using UnityEngine;

namespace Spawner
{
    public class SummonBerries : MonoBehaviour
    {
        [Header("Initial time between summon")]
        [SerializeField] private float timeSummonFrom;
        [SerializeField] private float timeSummonTo;

        [Header("Settings")]
        [SerializeField] private BerryRandomizer berryRandomizer;
        [SerializeField] private SpawnerRandomizer spawnerRandomizer;

        private void Start()
        {
            StartCoroutine(SammonCoroutine());
        }

        private void Sammon()
        {
            GameObject berryToSpawn = berryRandomizer?.GetRandomBerry();
            GameObject spawnPoint = spawnerRandomizer?.GetRandomSpawner();

            if (berryToSpawn != null && spawnPoint != null)
            {
                Instantiate(berryToSpawn, spawnPoint.transform.position, spawnPoint.transform.rotation);
            }         
        }

        private IEnumerator SammonCoroutine()
        {          
            while (true)
            {
                
                float timeBetweenSummon = Random.Range(timeSummonFrom, timeSummonTo);
                yield return new WaitForSeconds(timeBetweenSummon);
                Sammon();
            }
        }

        public void ChangeTimeSummon(float coefficient)
        {
            timeSummonFrom *= coefficient;
            timeSummonTo *= coefficient;
        }
    }
}

