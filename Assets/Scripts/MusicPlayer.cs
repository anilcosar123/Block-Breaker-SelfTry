using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    public static MusicPlayer Dontrepeatmusic = null;

    void Awake()
    {
        if (Dontrepeatmusic != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Dontrepeatmusic = this;
            DontDestroyOnLoad(gameObject);
        }
    }
}
