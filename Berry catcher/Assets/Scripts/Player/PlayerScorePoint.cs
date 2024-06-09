using Game;
using UI;
using UnityEngine;

namespace Player
{
    public class PlayerScorePoint : MonoBehaviour
    {
        [Header("Score vars")]
        [SerializeField] private int maxScoreValue;

        [Header("Settings")]
        [SerializeField] private UIScorePoint scorePointUI;
        [SerializeField] private GameStatistics gameStatistics;
        [SerializeField] private PlayerKomboPoint playerKomboPoint;

        private int score;
        private int scoreMultiplier;

        public void Scoring(int pointValue)
        {
            scoreMultiplier = playerKomboPoint.SetScoreMultiplier();

            if (score < maxScoreValue) 
            {
                if (scoreMultiplier > 0)
                {
                    pointValue *= scoreMultiplier;
                }
                score += pointValue;
                scorePointUI.OutputScoreOnUI(score);
            }

            gameStatistics.CollectStatistics(score, scoreMultiplier);
        }       
    }
}

