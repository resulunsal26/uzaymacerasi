using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class olumculplatform : MonoBehaviour
{
    BoxCollider2D boxCollider2D;
    float randomhiz;
    bool hareket;
    float min, max;
    public bool Hareket
    {
        get
        {
            return hareket;
        }
        set
        {
            hareket = value;
        }
    }
    void Start()
    {
        randomhiz = Random.Range(0.5f, 1.0f);
        boxCollider2D = GetComponent<BoxCollider2D>();
        float objegenislik = boxCollider2D.bounds.size.x / 2;
        if (transform.position.x > 0)
        {
            min = objegenislik;
            max = ekranhesaplayicisi.instance.Genislik - objegenislik;

        }
        else
        {
            min = -ekranhesaplayicisi.instance.Genislik + objegenislik;
            max = -objegenislik;
        }
    }

    
    void Update()
    {
        if (hareket)
        {
            float pingpongx = Mathf.PingPong(Time.time * randomhiz, max - min) + min;
            Vector2 pingpong = new Vector2(pingpongx, transform.position.y);
            transform.position = pingpong;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag==("ayaklar"))
        {
            FindObjectOfType<oyunkontrol>().oyunubitir();
        }
    }
}
