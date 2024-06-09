using UnityEngine;

namespace UI
{
    public class UIGamePause : MonoBehaviour
    {
        [SerializeField] private GameObject pausePanel;

        public void OutputPausePanel(bool isPaused)
        {
            pausePanel.SetActive(isPaused);
        }
    }
}

