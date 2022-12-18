using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public Rigidbody2D playerBody;
    public float horizontalMoveSpeed = 8;
    public float verticalMoveSpeed = 8;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        if(Input.GetKey(KeyCode.UpArrow) && playerBody.velocity.y == 0)
        {
            playerBody.velocity = new Vector2(playerBody.velocity.x, verticalMoveSpeed);

        }
        if (horizontalInput != 0) 
        {
            playerBody.velocity = new Vector2(horizontalInput * horizontalMoveSpeed, playerBody.velocity.y);
        }
        

        Debug.Log(playerBody.velocity);
    }
}
