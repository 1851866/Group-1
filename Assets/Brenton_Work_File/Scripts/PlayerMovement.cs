﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public bool canMove = true;
    public static bool canChange = true;
    private float nowTime = 0.0f;
    public static int score = 0;
    public static int currentElement;

    private Vector3 target;
    private Vector3 pos;

    //Different Skins
    public GameObject water;
    public GameObject fire;
    public GameObject earth;
    public GameObject wind;

    public GameObject fireLane;
    public GameObject waterLane;
    public GameObject earthLane;
    public GameObject windLane;

    private GameObject currentLane;

    public AudioSource waterSound, fireSound, windSound, earthSound;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "water" || other.gameObject.tag == "fire" || other.gameObject.tag == "earth" || other.gameObject.tag == "wind")
        {
            canChange = false;
        }

        switch (other.gameObject.tag)
        {

            case "fire":    fireSound.Play();
                break;
            case "water": waterSound.Play();
                break;
            case "wind": windSound.Play();
                break;
            case "earth": earthSound.Play();
                break;
        }


    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "end")
        {
            canChange = true;
        }
    }

    void Start()
    {
        Time.timeScale = 1;
        canChange = false;
        checkColour();
    }

    // Update is called once per frame
    void Update()
    {
        nowTime = nowTime + 1 * Time.deltaTime;
        score = (int)(nowTime);


    
        pos = gameObject.transform.position;

        if ((Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A) )&& pos.x>=-1 &&canMove && canChange)
        {


            target =  new Vector3(pos.x - 1, 1, pos.z);
            canMove = false;

        }
        if ((Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D)) && pos.x <=1 && canMove && canChange)
        {


            target = new Vector3(pos.x + 1, 1, pos.z);
            canMove = false;
        }

        

        gameObject.transform.position = Vector3.Lerp(pos, target, (25+(score/10)) * Time.deltaTime);
        gameObject.transform.position = new Vector3(gameObject.transform.position.x, 1, gameObject.transform.position.z);

        float dist = Mathf.Abs(gameObject.transform.position.x - target.x);

        
        if (dist<0.1)
        {
            gameObject.transform.position = new Vector3(target.x, 1 , target.z);
            canMove = true;
        }

        Destroy(currentLane);
        checkColour();



        switch (gameObject.tag)
        {
            case "water":

                currentElement = 0;
                water.SetActive(true);
                fire.SetActive(false);
                earth.SetActive(false);
                wind.SetActive(false);
                break;
            case "fire":

                currentElement = 1;
                water.SetActive(false);
                fire.SetActive(true);
                earth.SetActive(false);
                wind.SetActive(false);
                break;
            case "earth":

                currentElement = 2;
                water.SetActive(false);
                fire.SetActive(false);
                earth.SetActive(true);
                wind.SetActive(false);
                break;
            case "wind":

                currentElement = 3;
                water.SetActive(false);
                fire.SetActive(false);
                earth.SetActive(false);
                wind.SetActive(true);
                break;
        }

        

    }

    void checkColour()
    {
        switch (gameObject.tag)
        {
            case "water":
                currentLane = Instantiate(waterLane, new Vector3(transform.position.x, 0.5f, 0), Quaternion.identity);
                break;
            case "fire":
                currentLane = Instantiate(fireLane, new Vector3(transform.position.x, 0.5f, 0), Quaternion.identity);
                break;
            case "earth":
                currentLane = Instantiate(earthLane, new Vector3(transform.position.x, 0.5f, 0), Quaternion.identity);
                break;
            case "wind":
                currentLane = Instantiate(windLane, new Vector3(transform.position.x, 0.5f, 0), Quaternion.identity);
                break;
        }
    }


}
