using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSounds : MonoBehaviour
{

    public AudioSource engineSound;
    

    public float startingPitch;
    public float timeToIncreasePitch;
    public float maxPitch;
    public float gearSwitchDelay;
    public float maxGearDelay;
    public float pitchDropGear;
    public float pitchDropLane;
    private float keySwitchRate;

    
    public Pause pauseScript;

    void Start()
    {
        engineSound.pitch = startingPitch;
    }

    void Update()
    {
        if (!pauseScript.isPaused)
        {
            if (!engineSound.isPlaying)
            {
                engineSound.Play();
            }
            if (engineSound.pitch <= maxPitch)
            {
                engineSound.pitch += startingPitch / timeToIncreasePitch * Time.deltaTime;

                if(Time.time > keySwitchRate)
                {
                    keySwitchRate = Time.time + gearSwitchDelay;
                    if(gearSwitchDelay <= maxGearDelay)
                    {
                        gearSwitchDelay += 0.3f;
                    }
                    GearSwitch();
                }
            }
        }
        else
        {
            engineSound.Stop();
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D))
        {
            LaneSwitch();
            
        }
    }


    private void GearSwitch()
    {
        engineSound.pitch -= pitchDropGear;
    }

    private void LaneSwitch()
    {
        if (engineSound.pitch >= 0.4f)
        {
            engineSound.pitch -= pitchDropLane;
        }
    }

}
