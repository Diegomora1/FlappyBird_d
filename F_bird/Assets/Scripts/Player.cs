using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D bird;
    private float speed = 100.0f;
    private float jumpForce = 8.0f;
    float h,v;
    private bool saltar = false;
    

    void Start()
    {
        bird = GetComponent<Rigidbody2D>();
        bird.AddForce(Vector2.right * speed);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            saltar = true;
        }
        
    }   
    
    void FixedUpdate()
    {
        
        if(saltar)
        {
            Jump();
            saltar = false;
        }
        
    }

    void Jump()
    {
        bird.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }
}


