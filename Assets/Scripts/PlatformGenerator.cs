using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
    public GameObject platform; 
    public Transform generationPoint; 
    
    private float platformWidth; 
    
    private float distanceBetween; 
    public float distanceBetweenMin;
    public float distanceBetweenMax; 

    //public ObjectPooler theObjectPool; 
    public GameObject[] thePlatforms; 
    private int platformSelector; 
    private float[] platformWidths; 

    void Start()
    {
        //how wide should the platform be?
        //platformWidth = platform.GetComponent<BoxCollider2D>().size.x; 
        platformWidths = new float[thePlatforms.Length]; 
        for (int i = 0; i < thePlatforms.Length; i++) {
            platformWidths[i] = thePlatforms[i].GetComponent<BoxCollider2D>().size.x;
        }
    }

    void Update()
    {
        //create a new platform
        if (transform.position.x < generationPoint.position.x) {
            distanceBetween = Random.Range(distanceBetweenMin, distanceBetweenMax);
            platformSelector = Random.Range(0, thePlatforms.Length); 
            transform.position = new Vector3(transform.position.x + platformWidths[platformSelector] + distanceBetween, transform.position.y, transform.position.z);
            Instantiate(thePlatforms[platformSelector], transform.position, transform.rotation); 
            
            /*
            //get the platform 
            GameObject newPlatform = theObjectPool.GetPooledObject();
            //place it where it belongs
            newPlatform.transform.position = transform.position; 
            newPlatform.transform.rotation = transform.rotation; 
            newPlatform.SetActive(true); 
            */ 
        }
    }
}
