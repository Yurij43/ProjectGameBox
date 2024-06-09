using UI;
using UnityEngine;

namespace Berries
{
    public class BerrySettings : MonoBehaviour
    {
        [SerializeField] private Berry berry;

        [Header("Parametrs")]
        [ReadOnly][SerializeField] private int pointValue;
        [ReadOnly][SerializeField] private int spawnFrequency;
        [SerializeField] private SpriteRenderer berrySpriteRenderer;
        [SerializeField] private UIBerryPointValue berryOutputValueUI;
        [SerializeField] private BerryAnimationController berryAnimationController;
        [SerializeField] private Rigidbody2D playerRb;
        [SerializeField] private CircleCollider2D playerCircleCollider;

        public Berry Berry
        { set { berry = value; } }
        public int PointValue
        { get { return pointValue; } }

        private void Awake()
        {
            InitializationBerry();
        }

        private void InitializationBerry()
        {
            if (berry != null)
            {
                transform.name = berry.name;
                SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();

                if (spriteRenderer != null)
                {
                    spriteRenderer.sprite = berry.sprite;
                }

                pointValue = berry.pointValue;
                spawnFrequency = berry.spawnFrequency;
            }
        }

        public void SwitchOffBerry()
        {
            berryOutputValueUI?.OutputBerryPointValueOnUI(pointValue);

            if (playerCircleCollider != null && playerRb != null && berrySpriteRenderer != null)
            {
                playerCircleCollider.enabled = false;
                playerRb.simulated = false;
                berrySpriteRenderer.sprite = null;
            }

            berryAnimationController?.RunPointValueAnimation();
        }

        public void DestroyBerry()
        {
            Destroy(gameObject);
        }
    }
}

