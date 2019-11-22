using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public bool hasStarted;

    private Paddle paddle;
    private new Rigidbody2D rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        paddle = FindObjectOfType<Paddle>();
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (!hasStarted)
        {
            transform.position = paddle.transform.position + Vector3.up * 0.7f;

            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                hasStarted = true;
                rigidbody.velocity = new Vector2(3f, 12f);
            }
        }
        
    }
}
