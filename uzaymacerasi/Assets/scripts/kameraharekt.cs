using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kameraharekt : MonoBehaviour
{
    float hiz;
    float hizlanma;
    float maksimumhiz;
    bool hareket;
    void Start()
    {
        hareket = true;
        if(secenekler.kolaydegeroku()==1)
        {
            hiz = 0.3f;
            hizlanma = 0.03f;
            maksimumhiz =1.5f;
        }
        if (secenekler.ortadegeroku() == 1)
        {
            hiz = 0.5f;
            hizlanma = 0.05f;
            maksimumhiz = 2.0f;
        }
        if (secenekler.zordegeroku() == 1)
        {
            hiz = 0.7f;
            hizlanma = 0.07f;
            maksimumhiz = 2.5f;
        }
       
    }
     
    
    void Update()
    {
        if(hareket)
        {
            kamerayihareketettir();
        }
       
    }
    void kamerayihareketettir()
    {
        transform.position += transform.up * hiz * Time.deltaTime;
        hiz += hizlanma * Time.deltaTime;
        if(hiz>maksimumhiz)
        {
            hiz = maksimumhiz;
        }
    }
    public void oyunbitti()
    {
        hareket = false;
    }
}
