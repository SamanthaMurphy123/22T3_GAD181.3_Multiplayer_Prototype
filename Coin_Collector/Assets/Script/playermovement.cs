using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    [SerializeField]
    private float speed;
    private Rigidbody2D body;

    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask groundLayer;
    private bool isTouchingGround;

    public static int numberOfCoin;

    public static Action<string> PlayerCollectsCoin = delegate { };

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        isTouchingGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
        float horizontalInput = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(horizontalInput * speed, body.velocity.y);


        // flip
        if (horizontalInput > 0.01f)
            transform.localScale = Vector3.one;
        else if (horizontalInput < -0.01f)
            transform.localScale = new Vector3(-1, 1, 1);

        if (Input.GetKey(KeyCode.W) && isTouchingGround)
            body.velocity = new Vector2(body.velocity.x, speed);
    }
    // A bool value indicating whether the player has collected a coin
    bool hasCollectedCoin = false;

    // Other code for the Player class goes here...

    public bool HasCollectedCoin()
    {
        // Return the hasCollectedCoin flag
        return hasCollectedCoin;
    }
    

}




