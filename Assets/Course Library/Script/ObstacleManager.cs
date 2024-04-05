using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    [SerializeField] private float speed = 10f;

    void Start()
    {
        
    }

    
    void Update()
    {
        ObstacleMoving();
    }

    private void ObstacleMoving()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
}
