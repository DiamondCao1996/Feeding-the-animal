using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundary : MonoBehaviour
{
    private float upBoundary = 30.0f;
    private float lowerBoundary = -10.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //The food will be removed after the upper boundary
        if (transform.position.z > upBoundary)
        {
            Destroy(gameObject);
            
        //The animals will be removed after touching the lower boundary
        }else if (transform.position.z < lowerBoundary)
        {
            Debug.Log("Game over!");
            Destroy(gameObject);
        }

    }
}
