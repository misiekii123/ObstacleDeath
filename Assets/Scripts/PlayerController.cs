using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject Player;

    private float width;
    private float height;

    private Vector3 MousePositon;

    void Start()
    {
        width = Screen.width;
        height = Screen.height;
    }

    void FixedUpdate()
    {
        MousePositon = Input.mousePosition;

        if (Input.GetMouseButtonDown(0))
        {
            if (MousePositon.x < width / 2)
            {
                Player.transform.position = new Vector3(-2f,-2.6f,0f);
            }

            if (MousePositon.x > width / 2)
            {
                Player.transform.position = new Vector3(2f, -2.6f, 0f);
            }
        }
    }
}
