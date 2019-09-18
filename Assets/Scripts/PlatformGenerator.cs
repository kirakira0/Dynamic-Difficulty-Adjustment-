using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
    public GameObject platform; 
    public Transform generationPoint; 
    public float distanceBetween; 
    public float platformWidth; 
    public float timeBeforeInitSpawn; 
    public float timeBetweenSpawns;
 

    void Start()
    {
        platformWidth = platform.GetComponent<BoxCollider2D>().size.x;
        InvokeRepeating("SpawnPlatforms", timeBeforeInitSpawn, timeBetweenSpawns); //generate a platform every x seconds
    }

    void SpawnPlatforms() {
        transform.position = new Vector3(transform.position.x + platformWidth + distanceBetween, transform.position.y, transform.position.z); 
        Instantiate (platform, transform.position, transform.rotation);
    }


}
