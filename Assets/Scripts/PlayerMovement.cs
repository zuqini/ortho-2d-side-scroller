using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Vector2 controlAxis = new Vector2(0f, 0f);
    private SpriteRenderer spriteRenderer;
    public Rigidbody2D body;
    public float forceMultiplier = 1f;
    public float maxY = 100f;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        controlAxis.x = Input.GetAxisRaw("Horizontal");
        controlAxis.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        if (body.position.y > maxY)
        {
            body.velocity = new Vector2(body.velocity.x, 0f);
            body.position = new Vector2(body.position.x, maxY);
        }
        else
        {
            body.AddForce(controlAxis * forceMultiplier * Time.deltaTime);
        }
        spriteRenderer.flipX = body.velocity.x < 0;
    }
}
