using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    public float moveSpeed;
    public float jumpHeight;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.velocity = new Vector2(rb.velocity.x, moveSpeed);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.velocity = new Vector2(rb.velocity.x, -moveSpeed);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector2(-moveSpeed, rb.velocity.y);
        }
    }
  } 