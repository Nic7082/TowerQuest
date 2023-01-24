using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class MovingPlatformScript : MonoBehaviour
{
    //Data Fields
    public GameObject platformPathStart;
    public GameObject platformPathEnd;
    public int speed;
    private Vector3 startPosition;
    private Vector3 endPosition;

    //Methods
    void Update()
    {
        startPosition = platformPathStart.transform.position;
        float timeScale = speed / Vector3.Distance(startPosition, endPosition);
        gameObject.transform.position = Vector3.Lerp(startPosition, endPosition, Mathf.Abs(Time.time* timeScale % 2 - 1));
    }
}
