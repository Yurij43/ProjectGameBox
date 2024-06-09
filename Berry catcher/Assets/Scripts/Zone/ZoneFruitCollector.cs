using Berries;
using Player;
using UnityEngine;

namespace Zone
{
    public class ZoneFruitCollector : MonoBehaviour
    {
        [SerializeField] private PlayerScorePoint playerScorePoint;
        [SerializeField] private PlayerKomboPoint playerKomboPoint;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.TryGetComponent<BerrySettings>(out var berrySettings))
            {
                playerKomboPoint.ÑountKombo(true);
                playerScorePoint.Scoring(berrySettings.PointValue);
                berrySettings.SwitchOffBerry();
            }
        }
    }
}

