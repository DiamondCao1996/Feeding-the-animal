using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 10.0f;
    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //To make sure the player is in the range of screen
        if (transform.position.x<-xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
       if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        //The player is controlled with horizontal axis
        horizontalInput = Input.GetAxis("Horizontal");
        
        //To control the speed of the player
        transform.Translate(Vector3.right * (horizontalInput * Time.deltaTime * speed));
        
        //To launch the projectile, which is the food in the game context
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Now we launch projectile
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
