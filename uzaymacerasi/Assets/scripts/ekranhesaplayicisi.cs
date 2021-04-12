using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ekranhesaplayicisi : MonoBehaviour
{
    public static ekranhesaplayicisi instance;
    float yukseklik;
    float genislik;
    public float Yukseklik
    {
        get
        {
            return yukseklik;
        }
    }
    public float Genislik
    {
        get
        {
            return genislik;
        }
    }

    // Start is called before the first frame update
    private void Awake()
    {
        if(instance==null)
        {
            instance = this;
        }
        else if(instance!=this)
        {
            Destroy(gameObject);
        }
        yukseklik = Camera.main.orthographicSize;
        genislik = yukseklik * Camera.main.aspect;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
