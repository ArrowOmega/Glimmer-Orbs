using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatform : MonoBehaviour
{
    bool isFalling = false;
    public float downSpeed = 0;

    public float TimeToFall = 1.0f;

    void OnCollisonEnter2D(Collision collider)
    {
        if (collider.gameObject.name == "Player")
        {
            GetComponent<Rigidbody>().useGravity = true;
            //Destroy(gameObject, TimeToFall);
        }
        if (transform.position.y <= -2.84f)
        {
            Destroy(gameObject);    
        }
    }

    
}
