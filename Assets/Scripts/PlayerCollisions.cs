using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class PlayerCollisions : MonoBehaviour
{
    
    public Text livesText;
    public int lives = 10; 
    public HailSpawner hailspawner;  
    public Transform platform; 
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        livesText.text = "LIVES: " + lives + "\r\n" + "projectile speed: " + hailspawner.projectileSpeed + "\r\n" + "platform width: " + platform.localScale.x; 
    }

    void OnTriggerEnter2D(Collider2D col) { 
        if (col.tag == "Projectile") {
            if (lives > 0) {
                lives -= 1; 
            }
        }
    }
}
