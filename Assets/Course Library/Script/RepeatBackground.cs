using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private Vector3 startPos;
    private float repeatSpeed;
    void Awake()
    {
        startPos = transform.position;
        repeatSpeed = GetComponent<BoxCollider>().size.x / 2;
    }

    
    void Update()
    {
        if (transform.position.x < startPos.x - repeatSpeed)
        {
            transform.position = startPos;
        }
    }
}
