using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public List<Ball> balls;

    private Ball ball;
    private Paddle paddle;
    private LoseCollider losecollider;
    //private LevelManager levelmanager;

    void Awake()
    {
        ball = Resources.Load<Ball>("Cthun Ball");
        paddle = GameObject.Find("Paddle").GetComponent<Paddle>();
        balls = new List<Ball>();
        //levelmanager = FindObjectOfType<LevelManager>();
        DontDestroyOnLoad(gameObject);
    }

    void LateUpdate()
    {

    }

    public void CreateBall(bool multiBall)
    {
        var b = Instantiate(ball, new Vector3(paddle.paddlePos, 2f), Quaternion.identity);
        balls.Add(b);
        if (multiBall)
        {
            b.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(-2, 2), 10f);
        }
        b.Init(multiBall);
    }

    //public void DestroyBall()
    //{
    //    Destroy(GameObject.Find("Cthun Ball(Clone)"));
    //    balls.Remove(ball);


    //}
}
