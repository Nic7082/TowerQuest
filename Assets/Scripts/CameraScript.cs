using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject myObj;
    public Transform mageTransform;
    public Camera myCamera;
    public Rigidbody2D myObjRigidBody;
    void Update()
    {
        //The current y coordinate of the game object
        float currentObjY = myObj.transform.position.y;

        //The current y coordinate of the camera
        float currentCameraY = myCamera.transform.position.y;
        
        //The space at the top and bottom of the camera that triggers the acension or decension of the camera
        float buffer = 2;
        
        //Size of camera
        float size = myCamera.orthographicSize;
        
        //Top of the camera
        float topOfCamera = currentCameraY + size;
        
        //Bottom of the camera
        float bottomOfCamera = currentCameraY - size ;

        //Camera move increment
        float cameraIncrement = (currentObjY - currentCameraY) / 60;

        if (currentObjY > topOfCamera - buffer) //if the camera needs to move up
        {
            myCamera.transform.position += new Vector3(0, cameraIncrement, 0);
        }
        else if (currentObjY < bottomOfCamera + buffer) //if the camera needs to move down
        {
            myCamera.transform.position += new Vector3(0, cameraIncrement, 0);
        }

        if ((mageTransform.position.y < bottomOfCamera || mageTransform.position.y > topOfCamera) && myObj.GetComponent<Rigidbody2D>().velocity.y == 0) {
            mageTransform.position = myObj.transform.position + new Vector3(0, myObj.transform.localScale.y, 0);
        }

    }
}
