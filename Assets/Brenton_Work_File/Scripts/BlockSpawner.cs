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


    private float timeBetweenWaves = 10f;

    private float timeToSpawn = 1f;

    private float newPattern = 0;
    private float oldPattern = 0;

    public GameObject loseMenu;

    public HighScore hscore;



    void Update()
    {
        if (EnemyMovement.dead)
        {
            hscore.Stop_S();
            loseMenu.SetActive(true);
        }


        timeBetweenWaves = 10- (PlayerMovement.score / 20);

        if (Time.time>=timeToSpawn)
        {


            newPattern = Random.Range(0, 5);//0,6


            switch (newPattern)
            {
                case 0:
                    spawnChaosWithChanger();
                    oldPattern = 0;
                    break;
                case 1:
                    spawnRandomLinesWithChanger();
                    oldPattern = 1;
                    break;
                case 2:
                    spawnZigZag();
                    oldPattern = 2;
                    break;
                case 3:
                    spawnHalves();
                    oldPattern = 3;
                    break;
                case 4:
                    spawnMovers();
                    oldPattern = 4;
                    break;

            }





            //spawnHalves();
            // spawnRandomLinesWithChanger();
            // spawnChaosWithChanger();
            timeToSpawn = Time.time + timeBetweenWaves;
        }
        

    }

    void spawnRandomLines()
    {
            int randomIndex;
            int randomElementIndex;

        for (int j=0; j<4; j++) {
            randomIndex = Random.Range(0, 5);
            for (int i = 0; i < 5; i++)
            {
                do
                {
                    randomElementIndex = Random.Range(0, 5);
                } while (randomElementIndex == PlayerMovement.currentElement);

                if (i != randomIndex)
                {
                    Instantiate(elements[randomElementIndex], new Vector3(spawnPoints[i].position.x, spawnPoints[i].position.y, spawnPoints[i].position.z + (10*j)), Quaternion.identity);
                }
                else
                {
                    Instantiate(elements[PlayerMovement.currentElement], new Vector3(spawnPoints[i].position.x, spawnPoints[i].position.y, spawnPoints[i].position.z + (10*j)), Quaternion.identity);
                }
            }
        }
     }

    void spawnRandomLinesWithChanger()
    {
        int randomIndex;
        int randomElementIndex;

        for (int j = 0; j < 3; j++)
        {
            randomIndex = Random.Range(0, 5);
            for (int i = 0; i < 5; i++)
            {
                do
                {
                    randomElementIndex = Random.Range(0, 5);
                } while (randomElementIndex == PlayerMovement.currentElement);

                if (i != randomIndex)
                {
                    Instantiate(elements[randomElementIndex], new Vector3(spawnPoints[i].position.x, spawnPoints[i].position.y, spawnPoints[i].position.z + (10 * j)), Quaternion.identity);
                }
                else
                {
                    Instantiate(elements[PlayerMovement.currentElement], new Vector3(spawnPoints[i].position.x, spawnPoints[i].position.y, spawnPoints[i].position.z + (10 * j)), Quaternion.identity);
                }
            }
        }

        spawnChanger();
    }

    void spawnAlternating()
    {

    }

    void spawnZigZag()
    {
        int randomIndex;
        int randomElementIndex;

        randomIndex = Random.Range(0, 5);
        for (int i = 0; i < 5; i++)
        {
            do
            {
                randomElementIndex = Random.Range(0, 5);
            } while (randomElementIndex == PlayerMovement.currentElement);

            if (i != randomIndex)
            {
                Instantiate(elements[randomElementIndex], new Vector3(spawnPoints[i].position.x, spawnPoints[i].position.y, spawnPoints[i].position.z + i), Quaternion.identity);
            }
            else
            {
                Instantiate(elements[PlayerMovement.currentElement], new Vector3(spawnPoints[i].position.x, spawnPoints[i].position.y, spawnPoints[i].position.z + i), Quaternion.identity);
            }
        }

        randomIndex = Random.Range(0, 5);
        for (int i = 0; i < 5; i++)
        {
            do
            {
                randomElementIndex = Random.Range(0, 5);
            } while (randomElementIndex == PlayerMovement.currentElement);

            if (i != randomIndex)
            {
                Instantiate(elements[randomElementIndex], new Vector3(spawnPoints[i].position.x, spawnPoints[i].position.y, spawnPoints[i].position.z + (15-i)), Quaternion.identity);
            }
            else
            {
                Instantiate(elements[PlayerMovement.currentElement], new Vector3(spawnPoints[i].position.x, spawnPoints[i].position.y, spawnPoints[i].position.z + (15 - i)), Quaternion.identity);
            }
        }

        randomIndex = Random.Range(0, 5);
        for (int i = 0; i < 5; i++)
        {
            do
            {
                randomElementIndex = Random.Range(0, 5);
            } while (randomElementIndex == PlayerMovement.currentElement);

            if (i != randomIndex)
            {
                Instantiate(elements[randomElementIndex], new Vector3(spawnPoints[i].position.x, spawnPoints[i].position.y, spawnPoints[i].position.z + (21+i)), Quaternion.identity);
            }
            else
            {
                Instantiate(elements[PlayerMovement.currentElement], new Vector3(spawnPoints[i].position.x, spawnPoints[i].position.y, spawnPoints[i].position.z + (21+i)), Quaternion.identity);
            }
        }

        randomIndex = Random.Range(0, 5);
        for (int i = 0; i < 5; i++)
        {
            do
            {
                randomElementIndex = Random.Range(0, 5);
            } while (randomElementIndex == PlayerMovement.currentElement);

            if (i != randomIndex)
            {
                Instantiate(elements[randomElementIndex], new Vector3(spawnPoints[i].position.x, spawnPoints[i].position.y, spawnPoints[i].position.z + (35 - i)), Quaternion.identity);
            }
            else
            {
                Instantiate(elements[PlayerMovement.currentElement], new Vector3(spawnPoints[i].position.x, spawnPoints[i].position.y, spawnPoints[i].position.z + (35 - i)), Quaternion.identity);
            }
        }



    }

    void spawnHalves()
    {

        int randomElementIndex;


            do
            {
                randomElementIndex = Random.Range(0, 5);
            } while (randomElementIndex == PlayerMovement.currentElement);

            Instantiate(elements[randomElementIndex], spawnPoints[0].position, Quaternion.identity);
            Instantiate(elements[randomElementIndex], spawnPoints[1].position, Quaternion.identity);
            Instantiate(elements[randomElementIndex], spawnPoints[2].position, Quaternion.identity);
            Instantiate(elements[PlayerMovement.currentElement], spawnPoints[3].position, Quaternion.identity);
            Instantiate(elements[PlayerMovement.currentElement], spawnPoints[4].position, Quaternion.identity);

        do
        {
            randomElementIndex = Random.Range(0, 5);
        } while (randomElementIndex == PlayerMovement.currentElement);

        Instantiate(elements[PlayerMovement.currentElement], new Vector3(spawnPoints[0].position.x, spawnPoints[0].position.y, spawnPoints[0].position.z + 10), Quaternion.identity);
        Instantiate(elements[PlayerMovement.currentElement], new Vector3(spawnPoints[1].position.x, spawnPoints[1].position.y, spawnPoints[1].position.z + 10), Quaternion.identity);
        Instantiate(elements[randomElementIndex], new Vector3(spawnPoints[2].position.x, spawnPoints[2].position.y, spawnPoints[2].position.z + 10), Quaternion.identity);
        Instantiate(elements[randomElementIndex], new Vector3(spawnPoints[3].position.x, spawnPoints[3].position.y, spawnPoints[3].position.z + 10), Quaternion.identity);
        Instantiate(elements[randomElementIndex], new Vector3(spawnPoints[4].position.x, spawnPoints[4].position.y, spawnPoints[4].position.z + 10), Quaternion.identity);

        do
        {
            randomElementIndex = Random.Range(0, 5);
        } while (randomElementIndex == PlayerMovement.currentElement);


        Instantiate(elements[randomElementIndex], new Vector3(spawnPoints[0].position.x, spawnPoints[0].position.y, spawnPoints[0].position.z + 20), Quaternion.identity);
        Instantiate(elements[randomElementIndex], new Vector3(spawnPoints[1].position.x, spawnPoints[1].position.y, spawnPoints[1].position.z + 20), Quaternion.identity);
        Instantiate(elements[randomElementIndex], new Vector3(spawnPoints[2].position.x, spawnPoints[2].position.y, spawnPoints[2].position.z + 20), Quaternion.identity);
        Instantiate(elements[PlayerMovement.currentElement], new Vector3(spawnPoints[3].position.x, spawnPoints[3].position.y, spawnPoints[3].position.z + 20), Quaternion.identity);
        Instantiate(elements[PlayerMovement.currentElement], new Vector3(spawnPoints[4].position.x, spawnPoints[4].position.y, spawnPoints[4].position.z + 20), Quaternion.identity);


        do
        {
            randomElementIndex = Random.Range(0, 5);
        } while (randomElementIndex == PlayerMovement.currentElement);

        Instantiate(elements[randomElementIndex], new Vector3(spawnPoints[0].position.x, spawnPoints[0].position.y, spawnPoints[0].position.z + 30), Quaternion.identity);
        Instantiate(elements[PlayerMovement.currentElement], new Vector3(spawnPoints[1].position.x, spawnPoints[1].position.y, spawnPoints[1].position.z + 30), Quaternion.identity);
        Instantiate(elements[randomElementIndex], new Vector3(spawnPoints[2].position.x, spawnPoints[2].position.y, spawnPoints[2].position.z + 30), Quaternion.identity);
        Instantiate(elements[PlayerMovement.currentElement], new Vector3(spawnPoints[3].position.x, spawnPoints[3].position.y, spawnPoints[3].position.z + 30), Quaternion.identity);
        Instantiate(elements[randomElementIndex], new Vector3(spawnPoints[4].position.x, spawnPoints[4].position.y, spawnPoints[4].position.z + 30), Quaternion.identity);
    }

    void spawnChaos()
    {
        int randomIndex ;
        int randomElementIndex;

        for (int i = 0; i < 38; i=i+2)
        {
            do
            {
                randomElementIndex = Random.Range(0, 5);
            } while (randomElementIndex == PlayerMovement.currentElement);

            randomIndex = Random.Range(0, 5);

            Instantiate(elements[randomElementIndex], new Vector3(spawnPoints[randomIndex].position.x, spawnPoints[randomIndex].position.y, spawnPoints[randomIndex].position.z + i), Quaternion.identity);
        }
    }

    void spawnChaosWithChanger()
    {
        int randomIndex;
        int randomElementIndex;

        
        for (int i = 0; i < 28; i = i + 2)
        {
            do
            {
            randomElementIndex = Random.Range(0, 5);
            } while (randomElementIndex == PlayerMovement.currentElement);

            randomIndex = Random.Range(0, 5);

            Instantiate(elements[randomElementIndex], new Vector3(spawnPoints[randomIndex].position.x, spawnPoints[randomIndex].position.y, spawnPoints[randomIndex].position.z + i), Quaternion.identity);
        }
        spawnChanger();
    }

    void spawnMovers()
    {
      
        int randomElementIndex;

        for (int i = 0; i < 40; i = i + 4)
        {

           randomElementIndex = Random.Range(5, 8);

            switch (randomElementIndex)
            {
                case 5:
                    Instantiate(elements[randomElementIndex], new Vector3(spawnPoints[2].position.x, spawnPoints[2].position.y, spawnPoints[2].position.z + i), Quaternion.identity);
                    break;
                case 6:
                    Instantiate(elements[randomElementIndex], new Vector3(spawnPoints[0].position.x, spawnPoints[0].position.y, spawnPoints[0].position.z + i), Quaternion.identity);
                    break;
                case 7:
                    Instantiate(elements[randomElementIndex], new Vector3(spawnPoints[4].position.x, spawnPoints[4].position.y, spawnPoints[4].position.z + i), Quaternion.identity);
                    break;
                    
            }

            
        }
    }





    void spawnChanger()
    {
        Instantiate(changer, new Vector3(spawnPoints[2].position.x, spawnPoints[2].position.y, spawnPoints[2].position.z + 28), Quaternion.identity);
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
