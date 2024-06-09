using UI;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Game
{
    public class GamePause : MonoBehaviour
    {
        [SerializeField] private UIGamePause gamePauseUI;

        private bool isPaused = false;
        private bool isCurrentSwinth = true;

        public void OnPause(InputAction.CallbackContext context)
        {
            if (context.performed && isCurrentSwinth)
            {
                TogglePause(true);
            }          
        }

        public void TogglePause(bool isInput)
        {
            isPaused = !isPaused;

            if (isPaused)
            {
                Time.timeScale = 0;
            }
            else
            {
                Time.timeScale = 1;
            }

            if (isInput)
            {
                gamePauseUI.OutputPausePanel(isPaused);
            }           
        }

        public void SwitchInput(bool isSwitch)
        {
            isCurrentSwinth = isSwitch;
        }
    }
}

