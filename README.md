Гатальский Юрий Николаевич

Техническая документация
1. Введение
Проект Berry catcher - это аркадная игра, где игрок управляет персонажем, собирающим ягоды. Проект использует Unity для создания интерактивного геймплея и имеет несколько ключевых компонентов, таких как управление здоровьем персонажа и пользовательский интерфейс (UI) для отображения состояния игры.

2. Архитектура системы
Основные компоненты системы включают:
PlayerHealth: Управляет здоровьем игрока.
UIPlayerHealth: Обновляет отображение здоровья на экране.
PlayerLose: Обрабатывает состояние проигрыша.
SpawnerBerriesPositionPoints: Управляет позициями для спавна ягод.
MenuController: Управляет взаимодействием в меню и паузой игры.

3. Описание классов и их функций
PlayerHealth
Управляет состоянием здоровья игрока, обработкой урона и проигрышем.

public class PlayerHealth : MonoBehaviour
{
    [SerializeField][Range(1, 5)] private int maxHealthPoints;
    [SerializeField] private UIPlayerHealth healthUI;
    [SerializeField] private PlayerLose loseHandler;
    private int currentHealthPoints;

    private void Start() { InitializeHealth(); }
    public void TakeDamage(int damage) { ... }
    private void InitializeHealth() { ... }
    private void HandlePlayerDeath() { ... }
    private void UpdateHealthUI() { ... }
}

UIPlayerHealth
Обновляет интерфейс для отображения текущего состояния здоровья игрока.

public class UIPlayerHealth : MonoBehaviour
{
    public void InitializeHealthUI(int maxHealth) { ... }
    public void UpdateHealthUI(int currentHealth) { ... }
}

PlayerLose
Обрабатывает состояние проигрыша и обновляет соответствующий UI.

public class PlayerLose : MonoBehaviour
{
    public void TriggerLoseCondition() { ... }
}

SpawnerBerriesPositionPoints
Управляет позициями для спавна ягод на игровой сцене.

public class SpawnerBerriesPositionPoints : MonoBehaviour
{
    [SerializeField] private int quantitySpawnerPoints;
    [SerializeField] private Transform leftPosition;
    [SerializeField] private Transform rightPosition;
    private GameObject[] spawnerPoints;
    private float spawnerWidth;

    private void Awake() { ... }
    public void SetSpawerPosition(int quantitySpawnerPoints) { ... }
    public void ChangeQuantitySpawnerPoints(int increaseValue) { ... }
}

MenuController
Управляет меню и состоянием паузы в игре.

public class MenuController : MonoBehaviour
{
    [SerializeField] private GameObject pausePanel;
    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private GameObject pauseMenuButton;
    [SerializeField] private GameObject gameOverMenuButton;

    private EventSystem eventSystem;
    void Start() { eventSystem = EventSystem.current; }
    void Update() { ... }
    public void LoadMainMenu() { ... }
}

4. Взаимодействие классов
PlayerHealth вызывает методы UIPlayerHealth для обновления интерфейса при изменении здоровья.
PlayerHealth вызывает метод PlayerLose при достижении здоровья нуля.
MenuController управляет активностью панелей паузы и конца игры, а также состоянием времени (Time.timeScale).

5. Примеры использования

Вызов получения урона: playerHealth.TakeDamage(10);

Инициализация здоровья: playerHealth.InitializeHealth();



