using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float[] ObstaclesPosition = { -1f, 1f };

    private float x;
    private float y;

    public GameObject obstacle;

    void Start()
    {   
        x = ObstaclesPosition[Random.Range(0, ObstaclesPosition.Length)];
        y = 5.75f;
        obstacle.transform.position = new Vector3(x, y);

    }

    
    void FixedUpdate()
    {
        obstacle.transform.position = new Vector3(x, y);
            y -= 0.1f;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Floor"))
        {
            //y = 5.75f;
            //x = ObstaclesPosition[Random.Range(0, ObstaclesPosition.Length)];
            Debug.Log("Touched Floor");
        }
    }
}
