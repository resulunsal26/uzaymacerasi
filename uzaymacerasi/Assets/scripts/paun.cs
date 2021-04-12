using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class paun : MonoBehaviour
{
    [SerializeField]
    Text puantxt = default;
    [SerializeField]
    Text altintxt = default;
    [SerializeField]
    Text oyunbittitxt = default;
    [SerializeField]
    Text oyunbittialtintxt = default;
    int puan,altin;
    int enyuksekpuan,enyuksekaltin;
    bool puantopla = true;
    void Start()
    {
        altintxt.text = "X" + altin;
    }

    
    void Update()
    {
        if(puantopla)
        {
            puan = (int)Camera.main.transform.position.y;
            puantxt.text = "Puan : " + puan;
        }
      
    }
   public void altinkazan()
     {
        FindObjectOfType<seskontrol>().altinses();
        altin++;
        altintxt.text = "X" + altin;
    }
    public void oyunbitti()
    {
        if(secenekler.kolaydegeroku()==1)
        {
            enyuksekpuan = secenekler.kolaypuandegeroku();
            enyuksekaltin = secenekler.kolayaltindegeroku();
            if(puan>enyuksekpuan)
            {
                secenekler.kolaypuandegerata(puan);
            }
            if(altin>enyuksekaltin)
            {
                secenekler.kolayaltindegerata(altin);
            }
        }
        if (secenekler.ortadegeroku() == 1)
        {
            enyuksekpuan = secenekler.ortapuandegeroku();
            enyuksekaltin = secenekler.ortaaltindegeroku();
            if (puan > enyuksekpuan)
            {
                secenekler.ortapuandegerata(puan);
            }
            if (altin > enyuksekaltin)
            {
                secenekler.ortaaltindegerata(altin);
            }
        }
        if (secenekler.zordegeroku() == 1)
        {
            enyuksekpuan = secenekler.zorpuandegeroku();
            enyuksekaltin = secenekler.zoraltindegeroku();
            if (puan > enyuksekpuan)
            {
                secenekler.zorpuandegerata(puan);
            }
            if (altin > enyuksekaltin)
            {
                secenekler.zoraltindegerata(altin);
            }
        }
        puantopla = false;
        oyunbittitxt.text= "Puan : " + puan;
        oyunbittialtintxt.text = "X" + altin;
    }
}
