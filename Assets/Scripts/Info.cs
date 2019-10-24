using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Info : MonoBehaviour
{
    public int lives = 10; 
    public Text livesText; 
    
    void Start() {
        Debug.Log("hello"); 
    }
    // Update is called once per frame
    void Update()
    {
        livesText.text = "LIVES: " + lives + "hello"; 
    }

    public void SubtractLife() {
        lives -= 1; 
    }
}
