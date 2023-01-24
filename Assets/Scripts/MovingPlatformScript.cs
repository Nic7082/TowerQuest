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
    private GameObject target = null;
    private Vector3 offset;
    
    //Methods
    void Start()
    {
        target = null;
    }
    
    void Update()
    {
        startPosition = platformPathStart.transform.position;
        endPosition = platformPathEnd.transform.position;
        float timeScale = speed / Vector3.Distance(startPosition, endPosition);
        gameObject.transform.position = Vector3.Lerp(startPosition, endPosition, Mathf.Abs(Time.time * timeScale % 2 - 1));
    }
    void OnTriggerStay2D(Collider2D col)
    {
        target = col.gameObject;
        offset = target.transform.position - transform.position;
    }
    void OnTriggerExit2D(Collider2D col)
    {
        target = null;
    }
    void LateUpdate()
    {
        if (target != null)
        {
            target.transform.position = transform.position + offset;
        }
    }
}
