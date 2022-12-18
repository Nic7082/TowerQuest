using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public Rigidbody2D playerBody;
    public float horizontalMoveSpeed = 8;
    public float verticalMoveSpeed = 8;
    public Transform playerTransform;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        bool upInput = Input.GetKey(KeyCode.UpArrow);

        if(upInput)
        {
            if (playerBody.velocity.y <= 0.01 && playerBody.velocity.y >= -0.01)
            {
            playerBody.velocity = new Vector2(playerBody.velocity.x, verticalMoveSpeed);

            }
        }
        playerBody.velocity = new Vector2(horizontalInput * horizontalMoveSpeed, playerBody.velocity.y);
        
        
        // if (playerTransform.rotation.z != 0)
        // {
        //     playerTransform.rotation = Quaternion.Euler(0, 0, 0);
        // }



    }
}
