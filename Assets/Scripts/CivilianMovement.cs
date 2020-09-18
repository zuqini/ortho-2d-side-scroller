using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CivilianMovement : MonoBehaviour
{
    private int direction = 0;
    public Rigidbody2D body;
    public BoxCollider2D playerCollider;
    public float impulse = 1f;

    void Start()
    {
        direction = Random.Range(0, 2) == 0 ? -1 : 1;
        GetComponent<SpriteRenderer>().flipX = direction == 1;

        InvokeRepeating("Walk", 0.5f, 0.5f);
    }

    void FixedUpdate()
    {
        if (body.Distance(playerCollider).distance > 10)
        {
            Destroy(this.gameObject);
        }
    }

    void Walk()
    {
        body.AddForce(new Vector2(direction * impulse, 0), ForceMode2D.Impulse);
    }
}
