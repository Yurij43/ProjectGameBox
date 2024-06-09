using Game;
using UnityEngine;

namespace Player
{  
    public class PlayerLose : MonoBehaviour
    {
        [SerializeField] private GameObject losePanel;
        [SerializeField] private GamePause gamePause;

        public void FinishLevel()
        {
            gamePause.TogglePause(false);
            gamePause.SwitchInput(false);
            OutputLosePanel();
        }

        private void OutputLosePanel()
        {
            losePanel.SetActive(true);
        }
    }
}

