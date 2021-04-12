using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menumanager : MonoBehaviour
{
    
    [SerializeField]
    Sprite[] muzik = default;
    [SerializeField]
    Button muzikbtn;
  
    void Start()
    {
        if(secenekler.kayitvarmi()==false)
        {
            secenekler.kolaydegerata(1);
        }
        if(secenekler.muzikvarmi()==false)
        {
            secenekler.muzikacikdegerata(1);
        }
        muzikayarlarıdenetle();
    }
   
   
    void Update()
    {
        
    }
   public  void oyunbaslat()
    {
        SceneManager.LoadScene("oyun");
    }
    public void puan()
    {
        SceneManager.LoadScene("puan");
    }
    public void ayarlar()
    {
        SceneManager.LoadScene("ayarlar");
    }
    public void seskontrol()
    {
       if(secenekler.muzikacikdegeroku()==1)
        {
           secenekler.muzikacikdegerata(0);
            muzikkontrol.instance.muzikcal(false);
            muzikbtn.image.sprite = muzik[0];
        }
       else
        {
            muzikkontrol.instance.muzikcal(true);
            secenekler.muzikacikdegerata(1);
            muzikbtn.image.sprite = muzik[1];
        }
    }
    void muzikayarlarıdenetle()
    {
        if(secenekler.muzikacikdegeroku()==1)
        {
            muzikbtn.image.sprite = muzik[1];
            muzikkontrol.instance.muzikcal(true);
        }
        else
        {
            muzikbtn.image.sprite = muzik[0];
            muzikkontrol.instance.muzikcal(false);
        }
    }

}
