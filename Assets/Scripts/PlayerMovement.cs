using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Vector2 controlAxis = new Vector2(0f, 0f);
    private SpriteRenderer spriteRenderer;
    public Rigidbody2D body;
    public float forceMultiplier = 1f;

    void Update()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        controlAxis.x = Input.GetAxisRaw("Horizontal");
        controlAxis.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        body.AddForce(controlAxis * forceMultiplier * Time.deltaTime);
        spriteRenderer.flipX = body.velocity.x < 0;
    }
}
