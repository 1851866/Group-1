using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{

    public GameObject loseMenu;
    public GameObject mainMenu;
    public GameObject gameMan;
    public GameObject scoreDisp;

    // Start is called before the first frame update
    void Start()
    {
        loseMenu.SetActive(false);
    }

    public void PlayGame()
    {
        scoreDisp.SetActive(true);
        mainMenu.SetActive(false);
        gameMan.SetActive(true);
        PlayerMovement.canChange=true;
    }

    public void RetryGame()
    {
        loseMenu.SetActive(false);
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
        
    }

    public void LoadMenu()
    {
        Debug.Log("Loading menu");
        SceneManager.LoadScene("SampleScene");

    }

    public void Credits()
    {
        SceneManager.LoadScene(1);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
