using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject Player;

    private float width;
    private float height;

    private Vector3 MousePositon;

    private float PlayerPosition;

    void Start()
    {
        width = Screen.width;
        height = Screen.height;
    }

    void FixedUpdate()
    {
        MousePositon = Input.mousePosition;

        if (!MenuManager.instance.buttons)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (MousePositon.x < width / 2)
                {
                    if (MenuManager.instance.level == 1 || MenuManager.instance.level == 2 || MenuManager.instance.level == 3)
                    {
                        Player.transform.position = new Vector3(-1f,-2.6f,0f);
                    }
                }

                if (MousePositon.x > width / 2)
                {
                    if (MenuManager.instance.level == 1 || MenuManager.instance.level == 2 || MenuManager.instance.level == 3)
                    {
                        Player.transform.position = new Vector3(1f, -2.6f, 0f);
                    }
                }
            }
        }
    }

    public void left()
    {
        if(MenuManager.instance.level == 1 || MenuManager.instance.level == 2 || MenuManager.instance.level == 3)
        {
            Player.transform.position = new Vector3(-1f, -2.6f, 0f);
        }
    }

    public void right()
    {
        if (MenuManager.instance.level == 1 || MenuManager.instance.level == 2 || MenuManager.instance.level == 3)
        {
            Player.transform.position = new Vector3(1f, -2.6f, 0f);
        }
    }
}
