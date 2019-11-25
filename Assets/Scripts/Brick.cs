using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    public static int BreakableCount = 0;
    public Sprite[] hitSprites;
    public GameObject smoke;

    public GameObject powerUpSmall;
    public GameObject powerUpBig;
    public GameObject powerUpBalls;

    private int maxHits;
    private int timesHit = 0;
    private bool isBreakable;
    private LevelManager levelmanager;

    void Start()
    {
        levelmanager = FindObjectOfType<LevelManager>();
        isBreakable = (tag == "breakable");
        if (isBreakable)
        {
            BreakableCount++;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (isBreakable)
        {
            HandleHits();
            HandlePowerUps();
        }
    }

    void HandleHits()
    {
        timesHit++;
        maxHits = hitSprites.Length + 1;
        if (timesHit >= maxHits)
        {
            BreakableCount--;
            levelmanager.AllBricksDestroyed();
            GameObject smokePuff = Instantiate(smoke, gameObject.transform.position, Quaternion.identity);
            smokePuff.GetComponent<ParticleSystem>().startColor = gameObject.GetComponent<SpriteRenderer>().color;
            Destroy(gameObject);
        }
        else
        {
            LoadSprite();
        }
    }

    void LoadSprite()
    {
        int spriteIndex = timesHit - 1;
        GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
    }

    void HandlePowerUps()
    {
        int powerUp = Random.Range(1, 10);
        if (timesHit >= maxHits)
        {
            switch (powerUp)
            {
                case 1:
                    Instantiate(powerUpBig, gameObject.transform.position, Quaternion.identity);
                    break;
                case 2:
                    Instantiate(powerUpSmall, gameObject.transform.position, Quaternion.identity);
                    break;
                case 3:
                    Instantiate(powerUpBalls, gameObject.transform.position, Quaternion.identity);
                    break;
            }
        }
    }
}
