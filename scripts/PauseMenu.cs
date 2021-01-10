using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public static bool GameIsOver = false;

    public GameObject pauseMenuUI;
    public GameObject gameOverMenuUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
        if(GameIsOver)
        {
            GameOver();
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }

    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }

    public void GameOver()
    {
        Time.timeScale = 0f;
        gameOverMenuUI.SetActive(true);
    }

    public void TryAgain()
    {
        GameIsOver = false;
        Time.timeScale = 1f;
        PlayerEat.hp = 100;
        PlayerEat.score = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
