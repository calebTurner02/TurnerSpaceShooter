using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using UnityEngine.SceneManagement;

public class Shooting : MonoBehaviour
{
   [SerializeField] float fltBulletSpeed = 20f;
    Rigidbody2D myRigidbody;
    MoveShip player;
    float fltXSpeed;
    
    
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        player = FindObjectOfType<MoveShip>();
        fltXSpeed = player.transform.localScale.x * fltBulletSpeed;
        
        
    }
    

    void Update()
    {
        myRigidbody.velocity = new Vector2 (fltXSpeed, 0f);

        
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Wall")
        {
            Destroy(gameObject);
        }
       // Destroy(gameObject);

       if(other.tag == "Enemy")
       {
           Destroy(other.gameObject);
           Destroy(gameObject); 
           

          
           
       }
    }

    void OnCollisionEnter2D(Collision2D other) 
    {
       Destroy(gameObject);
    }
}
