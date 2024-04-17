using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
    public float moveSpeed;
    
    public Rigidbody2D rb;

    private Vector2 MoveDirection;
    


    // Update is called once per frame
    void Update()
    {
        ProcessInputs();
        
    }
    
    void FixedUpdate()
    {
        //Physics Calculations
        Move();
    }

    void ProcessInputs()
    {
        float moveY = Input.GetAxisRaw("Vertical");

        MoveDirection = new Vector2(0f, moveY).normalized;
    }

    void Move()
    {
        rb.velocity = new Vector2(0f, MoveDirection.y * moveSpeed);
    }

    
}
