using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Moving : MonoBehaviour
{
    float horizontalMove = 0f;
    public float speed;
    public float jumpHeight;
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private bool grounded;
    private bool doubleJumped;
    string sceneName;

    public AudioSource jumpSource;
    public AudioClip jumpSound;

    // Use this for initialization

    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;
    }

    private void FixedUpdate()
    {
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
    }

    // Update is called once per frame
    void Update()
    {
        if (grounded)
        {
            doubleJumped = false;
        }

        if (Input.GetKeyDown("w") && grounded)
        {
            Jump();

        }
        if ((sceneName == "Level2") && Input.GetKeyDown("w") && !doubleJumped && !grounded)
        {
            Jump();
            doubleJumped = true;
        }
        
        if (Input.GetKey("a"))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-speed, GetComponent<Rigidbody2D>().velocity.y);
            GetComponent<Animator>().SetFloat("Speed", 1);
            GetComponent<SpriteRenderer>().flipX = true; //Face Character Left
        }
        if (Input.GetKey("d"))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(speed, GetComponent<Rigidbody2D>().velocity.y);
            GetComponent<Animator>().SetFloat("Speed", 1);
            GetComponent<SpriteRenderer>().flipX = false; //Face Character Right
        }
        else
        {
            GetComponent<Animator>().SetFloat("Speed", 0);
        }
    }

    public void Jump()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
    }
}
