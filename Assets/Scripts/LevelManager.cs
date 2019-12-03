using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    private Controller controller;

    void Awake()
    {
        controller = FindObjectOfType<Controller>();
    }
    public void LoadLevel(string name)
    {
        Brick.BreakableCount = 0;
        SceneManager.LoadScene(name);
        controller.balls.Clear();
    }

    public void LoadNextLevel()
    {
        Brick.BreakableCount = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        controller.balls.Clear();
    }

    public void AllBricksDestroyed()
    {
        if (Brick.BreakableCount <= 0)
        {
            LoadNextLevel();
        }
    }
}
