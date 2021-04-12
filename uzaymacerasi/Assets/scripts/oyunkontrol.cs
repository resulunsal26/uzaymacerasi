using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class oyunkontrol : MonoBehaviour
{
    public GameObject oyunbittipanel;
    public GameObject joystick;
    public GameObject ziplamabtn;
    public GameObject tabela;
    public GameObject geridonbtn;
    public GameObject slider;

    void Start()
    {
        oyunbittipanel.SetActive(false);
        uıac();
    }

   
    
    public void oyunubitir()
    {
        FindObjectOfType<seskontrol>().bittises();
        FindObjectOfType<paun>().oyunbitti();
        oyunbittipanel.SetActive(true);
        FindObjectOfType<oyuncuhareket>().oyunbitti();
        FindObjectOfType<kameraharekt>().oyunbitti();
        uıkapat();
    }
    public void tekraroyna()
    {
        SceneManager.LoadScene("Oyun");
    }
    public void geridon()
    {
        SceneManager.LoadScene("menuscene");
    }
     void uıac()
    {
        joystick.SetActive(true);
        ziplamabtn.SetActive(true);
        tabela.SetActive(true);
        geridonbtn.SetActive(true);
        slider.SetActive(true);
    }
    void uıkapat()
    {
        joystick.SetActive(false);
        ziplamabtn.SetActive(false);
        tabela.SetActive(false);
        geridonbtn.SetActive(false);
        slider.SetActive(false);

    }
}
