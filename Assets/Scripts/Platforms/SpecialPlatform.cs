using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialPlatform : MonoBehaviour
{
    
    public GameObject player;

    void Start()
    {
        int layerToMove = LayerMask.NameToLayer(player.name);
        gameObject.layer = layerToMove;
    }
}
