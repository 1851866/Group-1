using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestingAudipScript : MonoBehaviour
{
    private MainAudioManager audioManger;


    // Start is called before the first frame update
    void Start()
    {
        audioManger = GameObject.FindGameObjectWithTag("SoundController").GetComponent<MainAudioManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            audioManger.FireSound();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            audioManger.WaterSound();
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            audioManger.EarthSound();
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            audioManger.WindSound();

        }
        
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            SceneManager.LoadScene("Test2");
        }

       
    }
}
