using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
     
    public Transform objectMoving;
    public Rigidbody2D objectMovingBody;
    private Vector3 originalPosition;
    public Vector3 displacement;
    private Vector3 endingPosition;
    private bool isClicked = false;
    private int cooldown = 0;


    void Start()
    {
        originalPosition = objectMoving.position;
        endingPosition = originalPosition + displacement;

        
    }

    void Update()
    {
        cooldown += 1;   
        if (isClicked && Vector3.Distance(endingPosition, objectMoving.position) > .01)
        {
            objectMovingBody.velocity = displacement;
        }
        else if(!isClicked && Vector3.Distance(originalPosition, objectMoving.position) > .01)
        {
            objectMovingBody.velocity = -displacement;
        } 
        else 
        {
            objectMovingBody.velocity = new Vector2(0,0);
        }

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("contact");
        if (cooldown > 15)
        {
            isClicked = !isClicked;
            if (!isClicked)
            {
                transform.localPosition = new Vector3(-.1f, .2f, 0);
                transform.localRotation = Quaternion.Euler(0, 0, -45);
            }
            else 
            {
                transform.localPosition = new Vector3(.1f, .2f, 0);
                transform.localRotation = Quaternion.Euler(0, 0, 45);
            }

            cooldown = 0;
        }
    }
}
