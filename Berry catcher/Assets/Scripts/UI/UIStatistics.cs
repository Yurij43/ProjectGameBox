using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class UIStatistics : MonoBehaviour
    {
        [SerializeField] private Text scoreText;
        [SerializeField] private Text maxKomboText;

        public void OutputStatisticsOnUI(int score, int maxKombo)
        {
            scoreText.text = $"Score: {score}";
            maxKomboText.text = $"Max Kombo: {maxKombo}";
        }
    }
}

