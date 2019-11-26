using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    private Ball ball;
    private Paddle paddle;
    private Brick brick;
    private LoseCollider losecollider;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MultiBalls()
    {
        Instantiate(ball, gameObject.transform.position, Quaternion.identity);
        Instantiate(ball, gameObject.transform.position, Quaternion.identity);
    }
}
