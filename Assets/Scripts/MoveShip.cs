using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MoveShip : MonoBehaviour
{
    //set move speed for ship
    [SerializeField] float fltMoveSpeed = 10f;
    [SerializeField] GameObject bullet;
    [SerializeField] Transform gun;
    [SerializeField] Transform gun2;

Vector2 moveInput;

 Rigidbody2D myRigidBody;
 //Get move input and check in the console 
  void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
        Debug.Log(moveInput);
    }
   
   //add rigidbody to ship
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();

    }   
    //Update the move when button is pressed
    void Update()
    {
        Move();
        
    }
    //Move the ship and multiply it by the set speed
    void Move()
    {
        myRigidBody.velocity = moveInput * fltMoveSpeed;
    }

      void OnFire(InputValue value)
    {
        Instantiate(bullet, gun.position, transform.rotation);

        Instantiate(bullet, gun2.position, transform.rotation);
    }
}
