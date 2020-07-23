using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private float speed;
    private Collider enemyCollider;
    public static bool dead = false;



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
                dead = true;
                PlayerMovement.canChange = false;
                Time.timeScale = 0;
            }
            
        }


        
    }


    // Start is called before the first frame update
    void Start()
    {
        dead = false;
        enemyCollider = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(PlayerMovement.score);

        
    }
}
