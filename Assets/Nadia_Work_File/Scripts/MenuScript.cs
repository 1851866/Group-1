using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("AttemptTwo");
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

    public void HowTo()
    {
        SceneManager.LoadScene("How To");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
