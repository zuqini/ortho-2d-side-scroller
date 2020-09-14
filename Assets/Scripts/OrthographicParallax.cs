﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrthographicParallax : MonoBehaviour
{
    private float length;
    private Vector3 startPos;

    public GameObject mainCamera;

    public float maxDepth = 100;

    void Start()
    {
       startPos = transform.position;
       length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    void FixedUpdate() 
    {
        var cameraPos = mainCamera.transform.position;
        var dist = cameraPos * (startPos.z / maxDepth);

        if (cameraPos.x > startPos.x + dist.x + length)
        {
            startPos.x += length;
        }
        else if (cameraPos.x < startPos.x + dist.x - length) 
        {
            startPos.x -= length;
        }

        transform.position = new Vector3(startPos.x + dist.x, startPos.y + dist.y, transform.position.z);
    }
}
