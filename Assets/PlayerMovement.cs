using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D player;
    private Vector3 right;   
    // Start is called before the first frame update
    void Start()
    {
        player = this.GetComponent<Rigidbody2D>();
        right = new Vector3(0.3f, 0.0f, 0.0f); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow)) {
            player.AddForce(right, ForceMode2D.Impulse); 
        }
        if (Input.GetKey(KeyCode.LeftArrow)) {
            player.AddForce(-right, ForceMode2D.Impulse); 
        }
    }
}
