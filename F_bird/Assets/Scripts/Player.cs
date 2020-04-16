using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D bird;
    private float speed = 200.0f;
    private float jumpForce = 10.0f;
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
            if(bird.velocity.y > 0.5f)
            {
                bird.velocity =  new Vector2(bird.velocity.x, 0.0f);
            }
            Jump();
            saltar = false;
        }
        
    }

    void Jump()
    {
        bird.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }

}


