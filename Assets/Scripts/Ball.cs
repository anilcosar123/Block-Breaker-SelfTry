using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public bool hasStarted;

    private bool multiBall;
    private bool hasInitialized;
    private Paddle paddle;
    private new Rigidbody2D rigidbody;

    void Start()
    {
        paddle = FindObjectOfType<Paddle>();
        rigidbody = GetComponent<Rigidbody2D>();
    }

    public void Init(bool multiBall)
    {
        hasInitialized = true;
        this.multiBall = multiBall;
    }
    void LateUpdate()
    {
        if (!hasInitialized)
        {
            return;
        }

        if (!hasStarted && !multiBall)
        {
            transform.position = paddle.transform.position + Vector3.up * 0.7f;

            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                hasStarted = true;
                rigidbody.velocity = new Vector2(2f, 10f);
            }
        }

    }
}
