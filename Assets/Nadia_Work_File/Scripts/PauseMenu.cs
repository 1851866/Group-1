using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GamePause = false;

    public GameObject pauseMenuUI;

    private Scene scene;

    private void Start()
    {
        scene = SceneManager.GetActiveScene();
    }



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GamePause)
            {
                Resume();

            }

            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GamePause = false;
        AudioListener.pause = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GamePause = true;
        AudioListener.pause = true;
    }

    public void LoadMenu()
    {
        Debug.Log("Loading menu");
        SceneManager.LoadScene("Menu");

    }

    public void QuitGame()
    {
        Debug.Log("Quitting Game");
        Application.Quit();
    }

    public void Credits()
    {
        Debug.Log("Credits");
        SceneManager.LoadScene("Credits");

    }

    public void Restart()
    {
        Debug.Log("Restart");
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1;

    }
}
