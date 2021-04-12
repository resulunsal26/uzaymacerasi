using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muzikkontrol : MonoBehaviour
{
    public static muzikkontrol instance;
    AudioSource audioSource;
    void Start()
    {
        singleton();
        audioSource = GetComponent<AudioSource>();
    }

   void singleton()
    {
        if(instance!=null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }
    }
    public void muzikcal(bool play)
    {
        if(play)
        {
            if(!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }
        else
        {
            if (audioSource.isPlaying)
            {
                audioSource.Stop();
            }
        }
    }
}
