using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class UIPlayerHealth : MonoBehaviour
    {
        [SerializeField] private Text playerHealthText;
        [SerializeField] private Slider playerHealthSlider;

        private int currentMaxHealthPoint;

        public void InitialValueHealthPointOnUI(int maxHealthPoint)
        {
            currentMaxHealthPoint = maxHealthPoint;
            playerHealthSlider.maxValue = currentMaxHealthPoint;
        }

        public void OutputHealthPointOnUI(int healthPoint)
        {
            playerHealthText.text = $"HP: {healthPoint}/{currentMaxHealthPoint}";
            playerHealthSlider.value = healthPoint;
        }
    }
}

