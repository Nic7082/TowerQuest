using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickableObject : MonoBehaviour
{
    public Transform objectMoving;
    public Rigidbody2D objectMovingBody;
    private Vector3 originalPosition;
    public Vector3 displacement;
    private Vector3 endingPosition;

    void Start()
    {
        originalPosition = objectMoving.position; // calculate original position of platform
        endingPosition = originalPosition + displacement; // calculate ending position of platform
    }


    public void runClick(bool isClicked)
    {
        if (isClicked && Vector3.Distance(endingPosition, objectMoving.position) > .01) // check if button is clicked and platform has not reached top
        {
            objectMovingBody.velocity = displacement; //set velocity to move toward ending position
        }
        else if(!isClicked && Vector3.Distance(originalPosition, objectMoving.position) > .01) // check if button is not clicked and platform has not reached bottom
        {
            objectMovingBody.velocity = -displacement; // set velocity to move opposite direction
        } 
        else 
        {
            objectMovingBody.velocity = new Vector2(0,0); // if reached bottom or top, or (for button) not clicked stop moving
        }
    }
}
