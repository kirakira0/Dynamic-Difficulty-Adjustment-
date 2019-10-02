// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class PlayerMovement : MonoBehaviour
// {
//     private Rigidbody2D player;
//     private Vector3 right;   
//     // Start is called before the first frame update
//     void Start()
//     {
//         player = this.GetComponent<Rigidbody2D>();
//         right = new Vector3(0.3f, 0.0f, 0.0f); 
//     }

//     // Update is called once per frame
//     void Update()
//     {
//         if (Input.GetKey(KeyCode.RightArrow)) {
//             player.AddForce(right, ForceMode2D.Impulse); 
//         }
//         if (Input.GetKey(KeyCode.LeftArrow)) {
//             player.AddForce(-right, ForceMode2D.Impulse); 
//         }
//     }
// }
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D my_rigidbody2d;
    private CircleCollider2D my_circlecol2d; 
    private BoxCollider2D my_boxcol2d; 
    private bool touchingFloor; 
    public int jumpForce = 10; 
    public int walkSpd = 5; 
    public int sprintSpd = 8; 
    
    // Start is called before the first frame update
    void Start()
    {
        my_rigidbody2d = this.GetComponent<Rigidbody2D>(); 
        my_circlecol2d = this.GetComponent<CircleCollider2D>(); 
        my_boxcol2d = this.GetComponent<BoxCollider2D>(); 

    }

    // Update is called once per frame
    void Update()
    {
        Move(); 
    }

    void Move() {
        //jump
        if (Input.GetKeyDown(KeyCode.Z) && touchingFloor) {
            my_rigidbody2d.velocity = new Vector2(my_rigidbody2d.velocity.x, jumpForce);  
        }
        //move right
        if (Input.GetKey(KeyCode.RightArrow)) {
            my_rigidbody2d.velocity = new Vector2(walkSpd, my_rigidbody2d.velocity.y);  
        }
        //move left 
        if (Input.GetKey(KeyCode.LeftArrow)) {
            my_rigidbody2d.velocity = new Vector2(-walkSpd, my_rigidbody2d.velocity.y);  
        }
        //dont move 
        if (!Input.anyKey){
            my_rigidbody2d.velocity = new Vector2(0, my_rigidbody2d.velocity.y); 
        }
    }
    
    void OnCollisionStay2D(Collision2D col) {
        if (col.collider.tag == "Floor") {
            touchingFloor = true;  
        }
    }
    void OnCollisionExit2D(Collision2D col) {
        if (col.collider.tag == "Floor") {
            touchingFloor = false;  
        }
    }

}
