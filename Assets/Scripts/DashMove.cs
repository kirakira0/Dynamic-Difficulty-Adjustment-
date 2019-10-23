using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashMove : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    private float dashTime;
    public float startTime;
    private int direction;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        dashTime = startTime;

        
    }

    // Update is called once per frame
    void Update()
    {
        if(direction == 0)
        {
            //TODO: Implement dash for right and left
            if (Input.GetKey(KeyCode.LeftArrow) && Input.GetKeyDown(KeyCode.X)){
                direction = 1;
            }
            else if (Input.GetKey(KeyCode.RightArrow) && Input.GetKeyDown(KeyCode.X)){
                direction = 2;
            }
            else if (Input.GetKeyDown(KeyCode.UpArrow)){
                direction = 3;
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow)){
                direction = 4;
            }

        }
        else{
            if(dashTime <= 0){
                direction = 0;
                dashTime = startTime;
                rb.velocity = Vector2.zero;
            }
            else {
                dashTime -= Time.deltaTime;
                if(direction == 1){
                    rb.velocity = Vector2.left * speed;
                }
                else if (direction == 2){
                    rb.velocity = Vector2.right * speed;
                }
                else if (direction == 3){
                    rb.velocity = Vector2.up * speed;
                }
                else if (direction == 4){
                    rb.velocity = Vector2.down * speed;
                }
            }
        }    
        Debug.Log(direction);
    }
}
