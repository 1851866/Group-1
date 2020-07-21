using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] elements;
    public GameObject changer;
    public GameObject slowMover;
    public GameObject fastMover;


    private float timeBetweenWaves = 2f;

    private float timeToSpawn = 2f;

    private float newPattern = 0;
    private float oldPattern = 0;


    void Update()
    {
        if (Time.time>=timeToSpawn)
        {

           
            if (oldPattern==3)
            {
                newPattern = 0;
            }
            else
            {

                if (oldPattern==0)
                {
                    newPattern = Random.Range(1, 3);
                }
                else
                {
                    newPattern = Random.Range(1, 4);
                }


               



            }

            switch (newPattern)
            {
                case 0:
                    spawnBlackLine();
                    oldPattern = 0; 
                    break;
                case 1:
                    spawnColourLine();
                    oldPattern = 1;
                    break;
                case 2:
                    spawnZigZag();
                    oldPattern = 2;
                    break;
                case 3:
                    spawnChanger();
                    oldPattern = 3;
                    break;

            }





            timeToSpawn = Time.time + timeBetweenWaves;
        }
        

    }


    void spawnZigZag()
    {
        int randomIndex = Random.Range(0, 5);
        int randomElementIndex;

        for (int i = 0; i < 5; i++)
        {
            randomElementIndex = Random.Range(0, 10);
            if (i!=randomIndex)
            {
                Instantiate(elements[randomElementIndex], new Vector3(spawnPoints[i].position.x, spawnPoints[i].position.y, spawnPoints[i].position.z + i), Quaternion.identity);
            }
            else
            {
                Instantiate(elements[PlayerMovement.currentElement], new Vector3(spawnPoints[i].position.x, spawnPoints[i].position.y, spawnPoints[i].position.z + i), Quaternion.identity);
            }
        }
  
    }

    void spawnColourLine()
    {
        int randomIndex = Random.Range(0, 5);
        int randomElementIndex;

        for (int i = 0; i < 5; i++)
        {
            randomElementIndex = Random.Range(0, 10);
            if (i != randomIndex)
            {
                Instantiate(elements[randomElementIndex],spawnPoints[i].position, Quaternion.identity);
            }
            else
            {
                Instantiate(elements[PlayerMovement.currentElement], spawnPoints[i].position, Quaternion.identity);
            }
        }

    }

    void spawnChanger()
    {
        Instantiate(changer, spawnPoints[2].position, Quaternion.identity);
    }

    void spawnBlackLine()
    {
        int randomIndex = Random.Range(0, 5);

        for (int i = 0; i < 5; i++)
        {
            
            if (i != randomIndex)
            {
                Instantiate(elements[5], spawnPoints[i].position, Quaternion.identity);
            }
           
        }

    }

    void spawnRandomblock()
    {
        int randomElementIndex = Random.Range(0, 10);
        int randomIndex = Random.Range(0, 5);
        Instantiate(elements[randomElementIndex], spawnPoints[randomIndex].position, Quaternion.identity);
    }
}
