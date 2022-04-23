using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
     [SerializeField] float fltMoveSpeed = 1f;

    Rigidbody2D myRigidbody;
    
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        myRigidbody.velocity = new Vector2 (fltMoveSpeed, 0f);
        GetComponent <Rigidbody2D>().velocity = new Vector2(-fltMoveSpeed,GetComponent<Rigidbody2D>().velocity.y);


    }

   void OnTriggerEnter2D(Collider2D other)
   {
       if(other.tag == "Wall")
       {
           Destroy(gameObject);
       }
   }
  
}

