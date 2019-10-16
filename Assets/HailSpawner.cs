using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HailSpawner : MonoBehaviour
{
    public GameObject hail; 

    private float nextActionTime = 0.0f;
    public float period = 0.1f;
    private float projectileSpeed = 1f; 
    public float maxSpeed = 5f; 
    
    void Start() {
        projectileSpeed = 1f; 
    }
    
    void Update () {        
        if (Time.time > nextActionTime ) {
            nextActionTime += period;
                Random rnd = new Random();
                Instantiate(hail, new Vector3(transform.position.x + Random.Range(-5f, 5f), transform.position.y, transform.position.z), Quaternion.identity);
        }
        if (projectileSpeed < maxSpeed) {
            projectileSpeed += 0.1f * Time.deltaTime; //speeds up the projectiles over time
            //Debug.Log(projectileSpeed); 
        }
        hail.GetComponent<Rigidbody2D>().gravityScale = projectileSpeed; 

    }
}
