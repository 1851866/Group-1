using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private float speed;
    private Collider enemyCollider;



    private void OnCollisionEnter(Collision collision)
    {
        if (this.gameObject.tag == collision.gameObject.tag)
        {
            enemyCollider.isTrigger = true;
        }
        else
        {

            if (collision.gameObject.name=="Player")
            {
                Time.timeScale = 0;
            }
            
        }


        
    }


    // Start is called before the first frame update
    void Start()
    {

        enemyCollider = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(PlayerMovement.score);
        speed = 2f;
        transform.Translate(0, 0, -1f * speed * Time.deltaTime);
        
    }
}
