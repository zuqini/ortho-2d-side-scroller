using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CivillianMovement : MonoBehaviour
{
    private int direction = 0;
    public Rigidbody2D body;
    public float impulse = 1f;

    void Start()
    {
        direction = Random.Range(0, 2) == 0 ? -1 : 1;
        InvokeRepeating("Walk", 0.5f, 0.5f);
    }

    void Walk()
    {
        body.AddForce(new Vector2(direction * impulse, impulse / 2), ForceMode2D.Impulse);
    }
}
