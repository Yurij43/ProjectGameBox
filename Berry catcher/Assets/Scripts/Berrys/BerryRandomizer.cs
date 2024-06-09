using UnityEngine;

namespace Berries
{
    public class BerryRandomizer : MonoBehaviour
    {
        [SerializeField] private Berry[] berries;
        [SerializeField] private BerrySettings berrySettingsPrefab;

        public GameObject GetRandomBerry()
        {
            if ((berries == null || berries.Length ==0) && berrySettingsPrefab == null)
            {
                return null;
            }

            int totalWeight = 0;

            foreach (Berry berry in berries)
            {
                totalWeight += berry.spawnFrequency;
            }

            int randomValue = Random.Range(0, totalWeight);
            int cumulativeWeight = 0;

            foreach (Berry berry in berries)
            {
                cumulativeWeight += berry.spawnFrequency;
                if (randomValue < cumulativeWeight)
                {
                    berrySettingsPrefab.Berry = berry;
                    GameObject berryPrefab = berrySettingsPrefab.gameObject;
                    return berryPrefab;
                }
            }

            return null;
        }
    }
}


