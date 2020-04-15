using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nivel1 : MonoBehaviour
{
    public Transform tubo;
    private float distance = 2.0f;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < 10; i++)
        {
           Instantiate(tubo, new Vector3(distance, 0, 0), Quaternion.identity);
           distance += 2.0f;  
        }
        
    }
}
