using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform : MonoBehaviour
{
    PolygonCollider2D polygonCollider2d;
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
       
        if (secenekler.kolaydegeroku() == 1)
        {
            randomhiz = Random.Range(0.2f, 0.8f);
        }
        if (secenekler.ortadegeroku() == 1)
        {
            randomhiz = Random.Range(0.5f, 1.0f);

        }
        if (secenekler.zordegeroku() == 1)
        {
            randomhiz = Random.Range(0.8f, 1.5f);
        }
        polygonCollider2d = GetComponent<PolygonCollider2D>();
        float objegenislik = polygonCollider2d.bounds.size.x / 2;
        if (transform.position.x>0)
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

    // Update is called once per frame
    void Update()
    {
        if(hareket)
        {
            float pingpongx = Mathf.PingPong(Time.time*randomhiz, max-min)+min;
            Vector2 pingpong = new Vector2(pingpongx, transform.position.y);
            transform.position = pingpong;
        }
    }
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ayaklar")
        {
            GameObject.FindGameObjectWithTag("Player").transform.parent = transform;
            GameObject.FindGameObjectWithTag("Player").GetComponentInChildren<oyuncuhareket>().ziplamayisifirla();
        }
    }
}
