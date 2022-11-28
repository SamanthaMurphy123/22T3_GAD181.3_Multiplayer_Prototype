using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement2 : MonoBehaviour
{
    [SerializeField]
    private float speed;
    private Rigidbody2D body;
    private float MovementX;

    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask groundLayer;
    private bool isTouchingGround;

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        MovementX = 0;
    }

    private void Update()
    {
        isTouchingGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
        body.velocity = new Vector2(MovementX * speed, body.velocity.y);


        if (Input.GetKey(KeyCode.J)) 
            {
            MovementX = -1;
            }

        if (Input.GetKey(KeyCode.L)) 
            {
            MovementX = -1;
            }
        if ((Input.GetKey(KeyCode.J) || Input.GetKey(KeyCode.L))) 
        {
            MovementX = 0;
        }


        if (Input.GetKey(KeyCode.RightShift) && isTouchingGround)
            body.velocity = new Vector2(body.velocity.x, speed);
    }
}
