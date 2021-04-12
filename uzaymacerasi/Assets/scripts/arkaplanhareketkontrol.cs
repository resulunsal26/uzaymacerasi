using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arkaplanhareketkontrol : MonoBehaviour
{
    float arkaplankonum;
    float mesafe = 10.24f;

    void Start()
    {
        arkaplankonum = transform.position.y;
        FindObjectOfType<gezegenler>().gezegenyerlestir(arkaplankonum);
    }

    // Update is called once per frame
    void Update()
    {
        if(arkaplankonum+mesafe<Camera.main.transform.position.y)
        {
            arkaplanyerlestir();
        }
    }
    void arkaplanyerlestir()
    {
        arkaplankonum += (mesafe * 2);
        FindObjectOfType<gezegenler>().gezegenyerlestir(arkaplankonum);
        Vector2 yenipozisyon = new Vector2(0, arkaplankonum);
        transform.position = yenipozisyon;
    }
}
