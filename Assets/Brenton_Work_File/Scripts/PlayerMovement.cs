﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public bool canMove = true;
    private float nowTime = 0.0f;
    public static int score = 0;

    private Vector3 target;
    private Vector3 pos;

    //Different Skins
    public GameObject water;
    public GameObject fire;
    public GameObject earth;
    public GameObject wind;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="water"|| collision.gameObject.tag == "fire" || collision.gameObject.tag == "earth" || collision.gameObject.tag == "wind" )
        {
            canMove = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "end")
        {
            canMove = true;
        }
    }

    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        nowTime = nowTime + 1 * Time.deltaTime;
        score = (int)(nowTime);


        pos = gameObject.transform.position;

        if (Input.GetKeyDown(KeyCode.LeftArrow)&&pos.x>=-1.9 &&canMove)
        {
       
            target =  new Vector3(pos.x - 1, 1, pos.z);
            canMove = false;

        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && pos.x <= 1.9&& canMove)
        {
            target = new Vector3(pos.x + 1, 1, pos.z);
            canMove = false;
        }

        

        gameObject.transform.position = Vector3.Lerp(pos, target, (20+(score/10)) * Time.deltaTime);
        gameObject.transform.position = new Vector3(gameObject.transform.position.x, 1, gameObject.transform.position.z);

        float dist = Mathf.Abs(gameObject.transform.position.x - target.x);

        Debug.Log(dist);
        if (dist<0.1)
        {
            gameObject.transform.position = new Vector3(target.x, 1 , target.z);
            canMove = true;
        }



        switch (gameObject.tag)
        {
            case "water":
                water.SetActive(true);
                fire.SetActive(false);
                earth.SetActive(false);
                wind.SetActive(false);
                break;
            case "fire":
                water.SetActive(false);
                fire.SetActive(true);
                earth.SetActive(false);
                wind.SetActive(false);
                break;
            case "earth":
                water.SetActive(false);
                fire.SetActive(false);
                earth.SetActive(true);
                wind.SetActive(false);
                break;
            case "wind":
                water.SetActive(false);
                fire.SetActive(false);
                earth.SetActive(false);
                wind.SetActive(true);
                break;
        }

    }


}