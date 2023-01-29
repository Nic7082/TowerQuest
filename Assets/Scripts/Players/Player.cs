using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D playerBody;
    public float horizontalMoveSpeed;
    public float verticalMoveSpeed;
    public KeyCode upInput;
    public KeyCode leftInput;
    public KeyCode rightInput;
    private bool onGround = false;

    public void playerMovement()
    {
        // variable to check if input is pressed
        bool isLeftInput = Input.GetKey(leftInput);
        bool isRightInput = Input.GetKey(rightInput);

        //Getting up input
        bool isUpInput = Input.GetKey(upInput);
        
        // if `isUpInput` is true and player is not jumping: Allow player to jump
        if(isUpInput && onGround)
            playerBody.velocity = new Vector2(playerBody.velocity.x, verticalMoveSpeed);
        
        // Move player left and right
        if (isRightInput) 
            playerBody.velocity = new Vector2(horizontalMoveSpeed, playerBody.velocity.y);

        if (isLeftInput) 
            playerBody.velocity = new Vector2(-horizontalMoveSpeed, playerBody.velocity.y);

    }
    public void OnTriggerStay2D(Collider2D col) 
    {
        onGround = true;
    }

    public void OnTriggerExit2D(Collider2D col)
    {
        onGround = false;
    }
    
}
