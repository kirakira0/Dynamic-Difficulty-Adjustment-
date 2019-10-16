using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Info : MonoBehaviour
{
    public int lives = 10; 
    public Text livesText; 

    // Update is called once per frame
    void Update()
    {
        livesText.text = "LIVES: " + lives; 
    }

    public void SubtractLife() {
        lives -= 1; 
    }
}
