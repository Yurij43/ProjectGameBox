using UI;
using UnityEngine;

namespace Player
{
    public class PlayerHealth : MonoBehaviour
    {
        [Header("Health vars")]
        [SerializeField][Range(1, 5)] private int maxHealthPoints;

        [Header("Settings")]
        [SerializeField] private UIPlayerHealth healthUI;
        [SerializeField] private PlayerLose loseHandler;

        private int currentHealthPoints;

        private void Start()
        {
            InitializeHealth();
        }

        private void InitializeHealth()
        {
            healthUI.InitialValueHealthPointOnUI(maxHealthPoints);
            currentHealthPoints = maxHealthPoints;
            healthUI.OutputHealthPointOnUI(currentHealthPoints);
        }

        public void TakeDamage(int damage)
        {
            currentHealthPoints -= damage;

            if (currentHealthPoints <= 0)
            {
                loseHandler.FinishLevel();
            }

            healthUI.OutputHealthPointOnUI(currentHealthPoints);                      
        }
    }
}

