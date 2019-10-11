using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HailSpawner : MonoBehaviour
{
    public GameObject hail; 

    private float nextActionTime = 0.0f;
    public float period = 0.1f;
 
    void Update () {
        if (Time.time > nextActionTime ) {
            nextActionTime += period;
            //for (int i = 0; i < 10; i++) {
                Random rnd = new Random();
                //Instantiate(hail, new Vector3(i * Random.Range(0f, 5f), Random.Range(0f, 2f), 0), Quaternion.identity);
                Instantiate(hail, new Vector3(0.1f * Random.Range(0f, 100f), 0.0f, Quaternion.identity);
            //} 
        }
    }
}
