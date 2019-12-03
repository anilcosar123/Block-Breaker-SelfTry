using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float paddlePos;

    private Controller controller;

    void Start()
    {
        controller = FindObjectOfType<Controller>();
        GameObject.Find("Main Camera").GetComponent<Controller>().CreateBall(false);
    }

    void Update()
    {
        MoveWithMouse();
    }

    void MoveWithMouse()
    {
        if (GetComponent<Transform>().localScale.x == 1f)
        {
            paddlePos = Mathf.Clamp((Input.mousePosition.x / Screen.width * 16), 0.8f, 15.2f);
            transform.position = new Vector3(paddlePos, 1f);
        }

        if (GetComponent<Transform>().localScale.x == 2.5f)
        {
            paddlePos = Mathf.Clamp((Input.mousePosition.x / Screen.width * 16), 2f, 14f);
            transform.position = new Vector3(paddlePos, 1f);
        }

        if (GetComponent<Transform>().localScale.x == 0.5f)
        {
            paddlePos = Mathf.Clamp((Input.mousePosition.x / Screen.width * 16), 0.4f, 15.6f);
            transform.position = new Vector3(paddlePos, 1f);
        }
    }

    void OnTriggerEnter2D(Collider2D trigger)
    {
        if (trigger.gameObject.name == "PowerUpSizeBig(Clone)")
        {
            GetComponent<Transform>().localScale = new Vector2(2.5f,1f);
        }

        if (trigger.gameObject.name == "PowerUpSizeSmall(Clone)")
        {
            GetComponent<Transform>().localScale = new Vector2(0.5f, 1f);
        }

        if (trigger.gameObject.name == "PowerUpSpawnBalls(Clone)")
        {
            if (controller.balls.Count == 1)
            {
                GameObject.Find("Main Camera").GetComponent<Controller>().CreateBall(true);
                GameObject.Find("Main Camera").GetComponent<Controller>().CreateBall(true);
            }
        }
    }
}
