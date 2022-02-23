using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public int[] ObstaclesPosition = { -1, 1 };

    public GameObject obstacle;

    void Start()
    {
        obstacle.transform.position = new Vector3(1f, 5.75f);
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag("Player") && !collision.CompareTag("Floor"))
        {

        }
    }
}
