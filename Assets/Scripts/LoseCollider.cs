using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseCollider : MonoBehaviour
{
    private LevelManager levelmanager;
    private Controller controller;
    
    private Ball ball;

    void Start()
    {
        controller = GetComponent<Controller>();
        levelmanager = FindObjectOfType<LevelManager>();
        
    }

    private void OnTriggerEnter2D(Collider2D trigger)
    {
        //if (trigger.gameObject.name == "Cthun Ball")
        //{
        //    _levelmanager = FindObjectOfType<LevelManager>();
        //    _levelmanager.LoadLevel("Lose");
        //}


        if (trigger.gameObject.name == "Cthun Ball(Clone)")
        {
            controller.DestroyBall();
            
            if (controller.balls.Count == 0)
            {
                levelmanager.LoadLevel("Lose");
            }
        }
    }
}
