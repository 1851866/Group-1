using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainAudioManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip[] music;

    public AudioSource waterSound, fireSound, windSound, earthSound, swerveSound;

   
    void Start()
    {
        if (!audioSource.playOnAwake)
        {
            audioSource.clip = music[Random.Range(0, music.Length)];
            audioSource.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.clip = music[Random.Range(0, music.Length)];
            audioSource.Play();
        }
    }

    void FireSound()
    {
        fireSound.Play();
    }
    void WaterSound()
    {
        waterSound.Play();

    }
    void EarthSound()
    {
        earthSound.Play();

    }
    void WinidSound()
    {
        windSound.Play();

    }

    void SwerveLane()
    {
        swerveSound.Play();
    }

}
