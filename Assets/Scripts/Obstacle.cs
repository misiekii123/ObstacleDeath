using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float[] ObstaclesPosition = {-1f,1f};

    private float x;
    private float y;

    public GameObject obstacle;

    public Vector3 movement;

    Rigidbody2D rb;

    void Start()
    {   
        x = ObstaclesPosition[Random.Range(0, ObstaclesPosition.Length)];
        y = 5.75f;
        obstacle.transform.position = new Vector3(x, y);

        rb = GetComponent<Rigidbody2D>();

      
        if(MenuManager.instance.level == 3)
        {
            movement = new Vector3(0f, -800f);
        }
        else if(MenuManager.instance.level == 2)
        {
            movement = new Vector3(0f, -500f);
        }
        else if (MenuManager.instance.level == 1)
        {
            movement = new Vector3(0f, -500f);
        }

        rb.AddForce(movement);
    }


    void FixedUpdate()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Floor"))
        {
            GameManager.instance.score++;
            GameManager.instance.UpdateOnScreenScore();
            y = 5.75f;
            x = ObstaclesPosition[Random.Range(0, ObstaclesPosition.Length)];
            obstacle.transform.position = new Vector3(x, y);
        }

        if (collision.CompareTag("Player"))
        {
            GameManager.instance.InGame = false;
        }
    }
}
