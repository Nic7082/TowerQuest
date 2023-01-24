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
    

    public void playerMovement()
    {
        // variable to check if input is pressed
        bool isUpInput = Input.GetKey(upInput);
        bool isLeftInput = Input.GetKey(leftInput);
        bool isRightInput = Input.GetKey(rightInput);
        // if `isUpInput` is true and player is not jumping: Allow player to jump
        if(isUpInput)
        {
            if (playerBody.velocity.y <= 0.001 && playerBody.velocity.y >= -0.001)
                 playerBody.velocity = new Vector2(playerBody.velocity.x, verticalMoveSpeed);
        }
        // Move player left and right
        if (isRightInput) 
            playerBody.velocity = new Vector2(horizontalMoveSpeed, playerBody.velocity.y);

        if (isLeftInput)
            playerBody.velocity = new Vector2(-horizontalMoveSpeed, playerBody.velocity.y);

    }
}
