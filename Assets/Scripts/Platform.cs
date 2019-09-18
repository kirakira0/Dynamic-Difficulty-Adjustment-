using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    
    private Vector2 targetPos;  
    public float speed;
    public GameObject platform; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        targetPos = new Vector2(platform.transform.position.x - 10, platform.transform.position.y); 

        //moves the platforms towards the player to give the illusion that the player is moving forwards
        platform.transform.position = Vector2.MoveTowards(platform.transform.position, targetPos, 5 * Time.deltaTime); 
        
        Debug.Log(platform.transform.position); 
    }

}
