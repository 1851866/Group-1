using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip[] music;
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    //reference this entire script either through a tag or a general public variable
    void Start()
    {
        //for music
        if (!audioSource.playOnAwake)
        {
            audioSource.clip = music[Random.Range(0, music.Length)];
            audioSource.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        //for music
        if (!audioSource.isPlaying)
        {
            audioSource.clip = music[Random.Range(0, music.Length)];
            audioSource.Play();
        }
    }
}
