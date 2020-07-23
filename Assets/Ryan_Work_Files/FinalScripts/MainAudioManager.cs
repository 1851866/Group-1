using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainAudioManager : MonoBehaviour
{

    public AudioSource waterSound, fireSound, windSound, earthSound, swerveSound;


    //reference when going through obstacles
    public void FireSound()
    {
        fireSound.Play();
    }
    //reference when going through obstacles
    public void WaterSound()
    {
        waterSound.Play();

    }
    //reference when going through obstacles
    public void EarthSound()
    {
        earthSound.Play();

    }

    //reference when going through obstacles
    public void WindSound()
    {
        windSound.Play();

    }
    
    //This is already referenced in the car sound script so don't worry about this
    public void SwerveLane()
    {
        swerveSound.Play();
    }

   

}
