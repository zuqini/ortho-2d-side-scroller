using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CivilianSpawner : MonoBehaviour
{
    public GameObject civilianPrefab;
    public float minX, maxX, y;
    public float rate;

    // This script will simply instantiate the Prefab when the game starts.
    void Start()
    {
        InvokeRepeating("SpawnCivilian", rate, rate);
    }

    void SpawnCivilian()
    {
        Instantiate(civilianPrefab, new Vector3(Random.Range(minX, maxX), y, 0), Quaternion.identity);
    }
}
