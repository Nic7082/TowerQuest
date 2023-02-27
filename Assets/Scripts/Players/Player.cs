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

    public Animator animator;

    public BoxCollider2D colld;


    private Vector2 defaultOffset;
    private Vector2 defaultSize;

    private bool onGround = false;
    private float wallVelocity = 0;

    public void Start()
    {
        defaultOffset = colld.offset;
        defaultSize = colld.size;

    }

    public void playerMovement(Vector2 jumpColOffset, Vector2 jumpColSize)
    {
        // variable to check if input is pressed
        bool isLeftInput = Input.GetKey(leftInput);
        bool isRightInput = Input.GetKey(rightInput);

        //Getting up input
        bool isUpInput = Input.GetKey(upInput);
        
        // if `isUpInput` is true and player is not jumping: Allow player to jump
        if(isUpInput && onGround)
        {

            colld.offset = jumpColOffset;
            colld.size = jumpColSize;

            playerBody.velocity = new Vector2(playerBody.velocity.x, verticalMoveSpeed);
            animator.Play("Jump");
        }
        
        // Move player left and right
        else if (isRightInput) 
        {
            setCollider(); 
            
            playerBody.velocity = new Vector2(horizontalMoveSpeed - wallVelocity, playerBody.velocity.y);
            transform.rotation = Quaternion.Euler(0, 180, 0);
            playRun();
        }

        else if (isLeftInput) 
        {
            setCollider();

            playerBody.velocity = new Vector2(-horizontalMoveSpeed + wallVelocity, playerBody.velocity.y);
            transform.rotation = Quaternion.Euler(0, 0, 0);
            playRun();
        }
        
        else if (onGround)
        {
            setCollider();

            animator.Play("idle");
        }

    }
    public void OnCollisionStay2D(Collision2D collision) 
    {
        if(collision.contacts.Length > 0)
        {
         ContactPoint2D contact = collision.contacts[0];
         if(Vector2.Dot(contact.normal, Vector2.up) > 0.5)
         {
             onGround = true;
         }

         
        }

        if (collision.transform.name == "Left Wall" || collision.transform.name == "Right Wall")
        {
            wallVelocity = horizontalMoveSpeed;
        }

    }

    public void OnCollisionExit2D(Collision2D col)
    {
        onGround = false;
        wallVelocity = 0;
    }

    public void playRun()
    {
        if (onGround)
        {
            animator.Play("Running");
        }
    }

    public void setCollider()
    {
        if (onGround)
        {
            colld.offset = defaultOffset;
            colld.size = defaultSize;
        }
    }
    
}
