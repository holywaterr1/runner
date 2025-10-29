using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Player : MonoBehaviour
{
    public float speed = 5f;

    private Rigidbody2D rb;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        rb.linearVelocity = new Vector2(horizontalInput * speed, rb.linearVelocity.y);

        if (rb.linearVelocity.x < 0)
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        if (rb.linearVelocity.x > 0)
            gameObject.GetComponent<SpriteRenderer>().flipX = false;

    }
}