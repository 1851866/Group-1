using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x<=2)
        {
            transform.Translate(1f * Time.deltaTime, 0f, 0f,Space.World);
        }
        else
        {
            //if (transform.position.x>-2)
            //{
                transform.Translate(-1f * Time.deltaTime, 0f, 0f, Space.World);
           // }
        }
    }
}
