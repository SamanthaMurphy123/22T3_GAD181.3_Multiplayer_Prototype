using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement2 : MonoBehaviour
{
    [SerializeField]
    private float speed;
    private Rigidbody2D body;
    private float MovementX;
    private float dirX, dirY, moveSpeed;
    private Vector3 currentScale;

    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask groundLayer;
    private bool isTouchingGround;


    public static int numberOfCoin;

    public static Action<string> PlayerCollectsCoin = delegate { };

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        MovementX = 0;

        currentScale = transform.localScale;
    }

    private void Update()
    {
        isTouchingGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
        body.velocity = new Vector2(MovementX * speed, body.velocity.y);

        if (Input.GetKey(KeyCode.L))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;

            currentScale.x = Mathf.Abs(currentScale.x);
            transform.localScale = currentScale;
        }
        if (Input.GetKey(KeyCode.J))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
            currentScale.x = -Mathf.Abs(currentScale.x);
            transform.localScale = currentScale;
        }

        if (Input.GetKey(KeyCode.I) && isTouchingGround)
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



