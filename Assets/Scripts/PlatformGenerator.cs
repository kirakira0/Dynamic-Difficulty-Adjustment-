using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
    public GameObject platform; 
    public Transform generationPoint; 
    public float distanceBetween; 
    
    private float platformWidth; 

    void Start()
    {
        //how wide should the platform be?
        platformWidth = platform.GetComponent<BoxCollider2D>().size.x; 
    }

    void Update()
    {
        //create a new platform
        if (transform.position.x < generationPoint.position.x) {
            transform.position = new Vector3(transform.position.x + platformWidth + distanceBetween, transform.position.y, transform.position.z);
            Instantiate(platform, transform.position, transform.rotation); 
        }
    }
}
