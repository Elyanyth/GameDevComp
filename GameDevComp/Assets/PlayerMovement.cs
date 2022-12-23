using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float MovementSpeed = 5f; //Mouvement Speed
    public Rigidbody2D rb; 
    Vector2 movement;
    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxis("Vertical");

    }

    void FixedUpdate() 
    {
        rb.MovePosition(rb.position + movement * MovementSpeed * Time.fixedDeltaTime);
    }

}