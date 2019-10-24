using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Hail : MonoBehaviour
{
    private GameObject canvas; 
    private Text canvasText; 

    void Start()
    {
        gameObject.tag = "Projectile"; 
    }

    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D col) { 
        if (col.tag == "Destroyer") {
            Destroy(gameObject, 0); 
        }        
    }
}
