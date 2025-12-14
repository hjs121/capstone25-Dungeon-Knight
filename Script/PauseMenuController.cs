using UnityEngine;

public class PauseMenuController : MonoBehaviour
{
    [Header("UI 패널 연결")]
    public GameObject pauseMenuPanel;
    public GameObject menuPanel;
    public GameObject settingsWindow;

    private bool isPaused = false;

    void Start()
    {
        if (pauseMenuPanel != null) pauseMenuPanel.SetActive(false);
    }

    void Update()
    {
        // ESC 키 입력
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused && settingsWindow.activeSelf)
            {
                OpenMenu();
            }
            else if (isPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    // 게임 일시정지
    public void Pause()
    {
        isPaused = true;
        Time.timeScale = 0f;

        pauseMenuPanel.SetActive(true);

        menuPanel.SetActive(true);
        settingsWindow.SetActive(false);
    }

    // 게임 재개
    public void Resume()
    {
        isPaused = false;
        Time.timeScale = 1f;

        pauseMenuPanel.SetActive(false);
    }
    
    // 설정 창 열기
    public void OpenSettings()
    {
        menuPanel.SetActive(false);
        settingsWindow.SetActive(true);
    }

    // 메뉴 창 열기
    public void OpenMenu()
    {
        settingsWindow.SetActive(false);
        menuPanel.SetActive(true);
    }

    // 게임 종료
    public void QuitGame()
    {
        Debug.Log("게임 종료");
        Application.Quit();
    }
}