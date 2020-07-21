using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    private float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 4f;
    }

    // Update is called once per frame
    void Update()
    {
        speed = 4 + PlayerMovement.score/5;
        transform.Translate(0, 0, -1f * speed * Time.deltaTime);
    }
}
