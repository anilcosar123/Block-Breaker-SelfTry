using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    void Update()
    {
        MoveWithMouse();
    }

    void MoveWithMouse()
    {
        float paddlePos = Mathf.Clamp((Input.mousePosition.x / Screen.width * 16), 0.8f, 15.2f);
        transform.position =  new Vector3(paddlePos,1f);
    }

    void OnTriggerEnter2D(Collider2D trigger)
    {
        if (trigger.gameObject.name == "PowerUpSizeBig(Clone)")
        {
            GetComponent<Transform>().localScale = new Vector2(2f,1f);
            Destroy(trigger);
        }

        if (trigger.gameObject.name == "PowerUpSizeSmall(Clone)")
        {
            GetComponent<Transform>().localScale = new Vector2(-2f, -1f);
            Destroy(trigger);
        }
    }
}
