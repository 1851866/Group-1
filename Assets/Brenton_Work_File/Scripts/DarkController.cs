using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DarkController : MonoBehaviour
{
    private float speed = 2f;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name=="Player")
        {
            
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, -1f * speed * Time.deltaTime);
    }
}
