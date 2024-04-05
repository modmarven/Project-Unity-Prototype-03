using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePref;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    [SerializeField] private float startDelay = 2f;
    [SerializeField] private float repeatRate = 2f;

    void Start()
    {
        InvokeRepeating("ObstacleSpawner", startDelay, repeatRate);
    }

    
    void Update()
    {
       
    }

    private void ObstacleSpawner()
    {
        Instantiate(obstaclePref, spawnPos, obstaclePref.transform.rotation);
    }
}
