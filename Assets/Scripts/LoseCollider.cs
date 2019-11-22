using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseCollider : MonoBehaviour
{
    private LevelManager _levelmanager;

    private void OnTriggerEnter2D(Collider2D trigger)
    { 
        _levelmanager = FindObjectOfType<LevelManager>();
        _levelmanager.LoadLevel("Lose");
    }
}
