using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MoveWithMouse();
    }

    void MoveWithMouse()
    {
        float paddlePos = Mathf.Clamp((Input.mousePosition.x / Screen.width * 16), 0.8f, 15.2f);
        transform.position =  new Vector3(paddlePos,1f);
    }
}
