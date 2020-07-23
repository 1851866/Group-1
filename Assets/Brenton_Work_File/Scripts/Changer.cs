using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Changer : MonoBehaviour
{

    int element; //Water =0 , Fire = 1, Earth = 2, Wind = 3

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name=="Player")
        {


            int currentE = PlayerMovement.currentElement;
            int newElement = Random.Range(0, 4); ;


            bool same=true;


            while (same==true)
            {

                if (newElement == currentE)
                {
                    same = true;
                    newElement = Random.Range(0, 4);
                }
                else
                {
                    same = false;
                }

                
            }


            switch (newElement)
            {
                case 0: other.tag = "water";
                    break;
                case 1: other.tag = "fire";
                    break;
                case 2: other.tag = "earth";
                    break;
                case 3: other.tag = "wind";
                    break;
            }
        }


    }

    // Start is called before the first frame update
    void Start()
    {
        element = 2;
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    private void elementChange()
    {




        int newElement;

        do
        {
            newElement = Random.Range(1, 5);
        } while (newElement==element);

        element = newElement;

    }
}
