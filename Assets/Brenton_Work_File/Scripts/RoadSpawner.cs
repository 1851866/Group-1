using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadSpawner : MonoBehaviour
{



    private float timeBetweenWaves = 1f;

    private float countdown = 1f;

    public GameObject roads;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeBetweenWaves = 1 - PlayerMovement.score / 20;


        if (countdown<=0f)
        {

            Instantiate(roads, new Vector3(0, 0, 10),Quaternion.identity);
            countdown = timeBetweenWaves;
        }

        countdown -= Time.deltaTime;
    }
}
