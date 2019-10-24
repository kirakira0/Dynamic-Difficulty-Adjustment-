using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HailSpawner : MonoBehaviour
{
    public GameObject hail; 
    public GameObject player; 
    public Transform platform; 

    private float nextActionTime = 0.0f;
    public float period = 0.1f;
    public float projectileSpeed = 1f; 
    public float maxSpeed = 5f; 
    public float minPlatformWidth = 3f; 
    public float platformShrinkSpeed = 20f; 
        
    void Start() {
        projectileSpeed = 1f; 
        platform.localScale = new Vector2(10f, platform.localScale.y); 
    }
    
    void Update () {        
        if (Time.time > nextActionTime ) {
            nextActionTime += period;
                Random rnd = new Random();
                //follows the player
                Instantiate(hail, new Vector3(player.transform.position.x + Random.Range(-5f, 5f), transform.position.y, transform.position.z), Quaternion.identity);
        }
        if (projectileSpeed < maxSpeed) {
            projectileSpeed += 0.1f * Time.deltaTime; //speeds up the projectiles over time
        }
        hail.GetComponent<Rigidbody2D>().gravityScale = projectileSpeed; 

        StartCoroutine(ScaleOverTime(platformShrinkSpeed));      
    }

    IEnumerator ScaleOverTime(float time)
     {
         Vector3 originalScale = platform.transform.localScale;
         Vector3 destinationScale = new Vector3(minPlatformWidth, platform.transform.localScale.y, platform.transform.localScale.z);
         
        float currentTime = 0.0f;  
        do
        {
        platform.transform.localScale = Vector3.Lerp(originalScale, destinationScale, currentTime / time);
        currentTime += Time.deltaTime;
        yield return null;
        } while (currentTime <= time);
     }
}
