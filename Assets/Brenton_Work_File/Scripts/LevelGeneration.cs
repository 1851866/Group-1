using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGeneration : MonoBehaviour
{
    private int[] xVal = new int[] {-2,-1,0,1,2};
    private int index;

    public GameObject dark;

    // Start is called before the first frame update
    void Start()
    {
        //for (int i =0; i<20;  i=i+4) {
        //    index = Random.Range(0, 5);
        //    Instantiate(dark, new Vector3(xVal[index], 1, 10+i), Quaternion.identity);
        //}

        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
