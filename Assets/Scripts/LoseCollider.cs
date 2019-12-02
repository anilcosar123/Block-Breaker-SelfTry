using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseCollider : MonoBehaviour
{
    private LevelManager levelmanager;
    private Controller controller;

    void Start()
    {
        controller = FindObjectOfType<Controller>();
        levelmanager = FindObjectOfType<LevelManager>();
    }

    private void OnTriggerEnter2D(Collider2D trigger)
    {
        if (trigger.gameObject.name == "Cthun Ball(Clone)")
        {
            if (controller.balls.Count == 0)
            {
                levelmanager.LoadLevel("Lose");
            }
        }
    }
}
