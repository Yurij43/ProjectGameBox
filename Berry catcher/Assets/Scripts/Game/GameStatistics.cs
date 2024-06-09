using UI;
using UnityEngine;

namespace Game
{
    public class GameStatistics : MonoBehaviour
    {
        [SerializeField] private UIStatistics statisticsUI;
        private int maxKombo = 0;

        public void CollectStatistics(int score, int kombo)
        {
            if (maxKombo < kombo)
            {
                maxKombo = kombo;              
            }

            statisticsUI.OutputStatisticsOnUI(score, maxKombo);
        }
    }
}

