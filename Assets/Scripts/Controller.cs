using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public Rigidbody2D myRigidBody2d;
    public float horizontalMoveSpeed = 8;
    public float verticalMoveSpeed = 8;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            myRigidBody2d.velocity = Vector2.up * verticalMoveSpeed;

        }
    }
}
