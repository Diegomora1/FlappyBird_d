using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nivel : MonoBehaviour
{
    public Transform tubo;
    private int score = 0; 
    private float distance = 3.0f;
    private float distTubos;
    private float posT1, posT2;
    
    
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
           GenTubos();
             
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    void GenTubos()
    {
        distTubos = Random.Range(7.5f,9.5f);
        posT1 = Random.Range(-2.0f, 0.0f);
        posT2 = Mathf.Abs(posT1) + distTubos;
        Instantiate(tubo, new Vector3(distance, posT1, 0), Quaternion.identity);
        Instantiate(tubo, new Vector3(distance, posT2, 0), Quaternion.AngleAxis(180, Vector3.right));
        distance += 4.5f;
    }
}
