using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Changer : MonoBehaviour
{

    private float speed;
    int element; //Water =1 , Fire = 2, Earth = 3, Wind = 4

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name=="Player")
        {
            elementChange();
            switch (element)
            {
                case 1: other.tag = "water";
                    break;
                case 2: other.tag = "fire";
                    break;
                case 3: other.tag = "earth";
                    break;
                case 4: other.tag = "wind";
                    break;
            }
        }


    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speed = 2f;
        transform.Translate(0, 0, -1f * speed * Time.deltaTime);
        
    }

    private void elementChange()
    {

        element = Random.Range(1, 5);
        Debug.Log(element);
    }
}
