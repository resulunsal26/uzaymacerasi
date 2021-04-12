using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seskontrol : MonoBehaviour
{
    public AudioClip ziplama;
    public AudioClip altin;
    public AudioClip bitti;
    AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

   public void ziplamases()
    {
        audioSource.clip = ziplama;
        audioSource.Play();
    }
    public void altinses()
    {
        audioSource.clip = altin;
        audioSource.Play();
    }
    public void bittises()
    {
        audioSource.clip = bitti;
        audioSource.Play();
    }

}
