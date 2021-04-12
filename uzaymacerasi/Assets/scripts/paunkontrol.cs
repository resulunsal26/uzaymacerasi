using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class paunkontrol : MonoBehaviour
{
    public Text kolaypuan, kolayaltin, ortapuan, ortaaltin, zorpuan, zoraltin;

    void Start()
    {
        kolaypuan.text = "Puan : " + secenekler.kolaypuandegeroku();
        kolaypuan.text = "X " + secenekler.kolayaltindegeroku();

        ortapuan.text = "Puan : " + secenekler.ortapuandegeroku();
        ortaaltin.text = "X " + secenekler.ortaaltindegeroku();

        zorpuan.text = "Puan : " + secenekler.zorpuandegeroku();
        zoraltin.text = "X " + secenekler.zoraltindegeroku();
    }

   
    public void anamenu()
    {
        SceneManager.LoadScene("menuscene");
    }
}
