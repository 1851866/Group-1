using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideToSideRight : MonoBehaviour
{
    public bool moving = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (moving == false)
        {
            StartCoroutine(Move());
        }
    }


    IEnumerator Move()
    {
        moving = true;
        for (int i = 0; i < 200; i++)
        {
            transform.Translate(-0.02f, 0, 0);
            yield return new WaitForSeconds(0.001f);
        }

        for (int i = 0; i < 200; i++)
        {
            transform.Translate(0.02f, 0, 0);
            yield return new WaitForSeconds(0.001f);
        }

        //for (int i = 0; i < 100; i++)
        //{
        //    transform.Translate(0.01f, 0, 0);
        //    yield return new WaitForSeconds(0.001f);
        //}
        moving = false;

    }
}
