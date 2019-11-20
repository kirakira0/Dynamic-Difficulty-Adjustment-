using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed; 
    public float jumpForce;
    
    private Rigidbody2D playerRigidbody;

    //variables for ground collision
    public bool grounded; 
    public LayerMask whatIsGround; 
    private Collider2D playerCollider;  

    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody2D>(); 
        playerCollider = GetComponent<Collider2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        grounded = Physics2D.IsTouchingLayers(playerCollider, whatIsGround); 
        playerRigidbody.velocity = new Vector2(moveSpeed, playerRigidbody.velocity.y);
        if (Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown(KeyCode.UpArrow) && grounded) {
            playerRigidbody.velocity = new Vector2(playerRigidbody.velocity.x, jumpForce);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) && grounded) {
            playerRigidbody.transform.localScale = new Vector3(playerRigidbody.transform.localScale.x, playerRigidbody.transform.localScale.y / 2, playerRigidbody.transform.localScale.z); 
        }
        if (Input.GetKeyUp(KeyCode.DownArrow) && grounded) {
            playerRigidbody.transform.localScale = new Vector3(playerRigidbody.transform.localScale.x, playerRigidbody.transform.localScale.y * 2, playerRigidbody.transform.localScale.z); 
        }
    }
}
