 using UnityEngine;
 using System.Collections;
     
[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour {

    public Vector3 jump;
    public Vector3 stop; 
    //public Vector3 dash; 
    public float jumpForce = 2.0f;
    public bool isGrounded;
    private Rigidbody2D player;

    void Start(){
        player = this.GetComponent<Rigidbody2D>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);
        stop = new Vector3(0.0f, 0.0f, 0.0f); 
        //dash = new Vector3(2.0f, 1.0f, 0.0f); 
    }

    void OnCollisionStay2D()
    {
        isGrounded = true;
    }

    void Update(){
        Debug.Log(isGrounded); 
        if(Input.GetKeyDown(KeyCode.Z) && isGrounded){
            //player.velocity = Vector3.zero; 
            //player.AddForce(stop); 
            player.AddForce(jump * jumpForce, ForceMode2D.Impulse);
            isGrounded = false;
        }

        // if(Input.GetKeyDown(KeyCode.X)){
        //     player.AddForce(dash * jumpForce, ForceMode2D.Impulse);
        // }
    }

    
    
}