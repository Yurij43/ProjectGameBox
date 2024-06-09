using UnityEngine;
using UnityEngine.EventSystems;

public class MenuController : MonoBehaviour
{
    [Header("Panels")]
    public GameObject pausePanel;
    public GameObject losePanel;

    [Header("Menu Buttons")]
    public GameObject pauseMenuButton;
    public GameObject LoseMenuButton;

    private EventSystem eventSystem;

    void Start()
    {
        eventSystem = EventSystem.current;
        Time.timeScale = 1f;
    }

    void Update()
    {
        if (pausePanel.activeSelf)
        {
            eventSystem.SetSelectedGameObject(pauseMenuButton);
        }
        else if (losePanel.activeSelf)
        {
            eventSystem.SetSelectedGameObject(LoseMenuButton);
        }
    }
}
