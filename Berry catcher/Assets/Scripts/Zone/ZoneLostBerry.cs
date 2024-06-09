using Berries;
using Player;
using UnityEngine;

namespace Zone
{
    public class ZoneLostBerry : MonoBehaviour
    {
        [SerializeField] private PlayerKomboPoint playerKomboPoint;
        [SerializeField] private PlayerHealth playerHealth;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.GetComponent<BerrySettings>())
            {
                playerHealth.TakeDamage(1);
                playerKomboPoint.ÑountKombo(false);
                Destroy(collision.gameObject);
            }
        }
    }
}

