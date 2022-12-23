using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell : MonoBehaviour
{
    public float speed;
    public int direction;
    private Collider2D mage;
    private Collider2D mageSideFriction;

    // Update is called once per frame
    void Start()
    {
        mage = GameObject.Find("Mage").GetComponent<Collider2D>();
        mageSideFriction = GameObject.Find("Mage Side Friction").GetComponent<Collider2D>();
    }
    void Update()
    {
        transform.Translate(Vector3.right * speed * direction);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!(other == mage || other == mageSideFriction))
        {
            Debug.Log(other);
            Destroy(gameObject);
        }

    }
}
