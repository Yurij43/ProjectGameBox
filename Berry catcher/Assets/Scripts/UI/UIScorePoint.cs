using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class UIScorePoint : MonoBehaviour
    {
        [SerializeField] private Text scoreText;      

        public void OutputScoreOnUI(int score)
        {
            scoreText.text = $"Score: {score}";
        }
    }
}

