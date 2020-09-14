using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Vector2 controlAxis = new Vector2(0f, 0f);
    private Vector2 velocity = new Vector2(0f, 0f);
    private SpriteRenderer spriteRenderer;

    public float acceleration = 1f;
    public float resistance = 0.1f;

    void Update()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        controlAxis.x = Input.GetAxisRaw("Horizontal");
        controlAxis.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        // apply acceleration
        velocity += acceleration * controlAxis * Time.deltaTime;
        spriteRenderer.flipX = velocity.x < 0;

        // apply velocity
        transform.position = transform.position + (Vector3) velocity;

        // apply air Resistance
        velocity = (1 - resistance) * velocity;
    }
}
