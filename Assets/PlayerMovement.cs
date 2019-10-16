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

    public float dashDuration = 1.0f; 
    private float currentDashTime; 
    private Vector2 moveDirection; 
    private float dashSpeed = 1.0f; 
    public float dashStoppingSpeed = 0.1f;  
    
    private bool currentlyDashing = false; 
    private float dashTime = 0.8f; 
    private string direction = "right"; 

    
    // Start is called before the first frame update
    void Start()
    {
        my_rigidbody2d = this.GetComponent<Rigidbody2D>(); 
        my_circlecol2d = this.GetComponent<CircleCollider2D>(); 
        my_boxcol2d = this.GetComponent<BoxCollider2D>(); 

        currentDashTime = dashDuration; 
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        //Dash();
        if (Input.GetKeyDown(KeyCode.X) && !currentlyDashing) {
            dashTime = 0.8f; 
            currentlyDashing = true; 
        }
 
    }

    // void Dash() {
    //     //TODO: make it so the player doesn't dash down if they're falling
    //     if (currentlyDashing && dashTime > 0) {
    //         //my_rigidbody2d.position = new Vector2(my_rigidbody2d.position.x + 0.1f, my_rigidbody2d.position.y); 
    //         if (direction == "right") {
    //             my_rigidbody2d.position = new Vector2(my_rigidbody2d.position.x + dashTime/2, my_rigidbody2d.position.y);
    //         } 
    //         else if (direction == "left") {
    //             my_rigidbody2d.position = new Vector2(my_rigidbody2d.position.x - dashTime/2, my_rigidbody2d.position.y);
    //         }
            
    //         dashTime -= Time.deltaTime; 
    //     }
    //     if (dashTime <= 0) {
    //         currentlyDashing = false; 
    //     }
 
    // }

    void Move() {
        //jump
        if (Input.GetKeyDown(KeyCode.Z) && touchingFloor) {
            my_rigidbody2d.velocity = new Vector2(my_rigidbody2d.velocity.x, jumpForce);  
        }
        //move right
        if (Input.GetKey(KeyCode.RightArrow)) {
            my_rigidbody2d.velocity = new Vector2(walkSpd, my_rigidbody2d.velocity.y);  
            direction = "right"; 
        }
        //move left 
        if (Input.GetKey(KeyCode.LeftArrow)) {
            my_rigidbody2d.velocity = new Vector2(-walkSpd, my_rigidbody2d.velocity.y);  
            direction = "left"; 
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
