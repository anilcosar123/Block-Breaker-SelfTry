using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSelfDestroy : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D trigger)
    {
        if (trigger.gameObject.name == "Paddle" || trigger.gameObject.name == "LoseCollider")
        {
            Destroy(gameObject);
        }
    }
}
