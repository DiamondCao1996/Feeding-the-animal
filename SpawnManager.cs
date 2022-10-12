using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnPosZ = 20.0f;
    private float spawnRangeX = 20.0f;
    private float spawnDelay = 2.0f;
    private float spawnInterval = 1.5f;
    

    
    // Start is called before the first frame update
    void Start()
    {
        //To invoke the repeating function to call the spawn function at a delay time, in a interval frequency
        InvokeRepeating("SpawnRandomAnimal", spawnDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    //This is the spawn function that we want to have
    //The function of the spawn method to generate the animal array at a certain position, rotation and call the animals in the array out randomly
    //The method will be called spontaneously because we use instantiate, so will generate copies of the game object continually
    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPoz = new Vector3(Random.Range(-spawnRangeX,spawnRangeX), 0, spawnPosZ);
        Instantiate(animalPrefabs[animalIndex], spawnPoz,
            animalPrefabs[animalIndex].transform.rotation);
    }
}
