using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CivilianSpawner : MonoBehaviour
{
    public GameObject civilianPrefab;
    public BoxCollider2D playerCollider;
    public float minX, maxX, y;
    public float rate;

    // This script will simply instantiate the Prefab when the game starts.
    void Start()
    {
        InvokeRepeating("SpawnCivilian", rate, rate);
    }

    void SpawnCivilian()
    {
        GameObject civilian = Instantiate(civilianPrefab, new Vector3(Random.Range(minX, maxX), y, 0), Quaternion.identity);
        civilian.GetComponent<CivilianMovement>().playerCollider = playerCollider;
    }
}
