using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{

    public float speed;
    public float jumpheight;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            transform.Translate(Vector3.up * jumpheight);
            if (Input.GetKey("a"))
            {
                transform.Translate(Vector3.left * speed);
                GetComponent<SpriteRenderer>().flipX = true; //Face Character Left
            }
            else if (Input.GetKey("d"))
            {
                transform.Translate(Vector3.right * speed);
                GetComponent<SpriteRenderer>().flipX = false; //Face Character Right
            }
        }
        else if (Input.GetKey("a"))
        {
            transform.Translate(Vector3.left * speed);
            GetComponent<SpriteRenderer>().flipX = true; //Face Character Left
        }
        else if (Input.GetKey("d"))
        {
            transform.Translate(Vector3.right * speed);
            GetComponent<SpriteRenderer>().flipX = false; //Face Character Right
        }
    }
}
