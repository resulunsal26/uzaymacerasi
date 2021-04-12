using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformpool : MonoBehaviour
{
    [SerializeField]
    GameObject platformprefab = default;
    [SerializeField]
    GameObject olumculplatformprefab = default;
    [SerializeField]
    GameObject playerprefab = default;
    Vector2 platformposition;
    Vector2 playerposition;
    [SerializeField]
    float platformarasimesafe = default;
    List<GameObject> platforms = new List<GameObject>();

    void Start()
    {
        platformuret();
    }

    // Update is called once per frame
    void Update()
    {
        if(platforms[platforms.Count-1].transform.position.y<Camera.main.transform.position.y+ekranhesaplayicisi.instance.Yukseklik)
        {
            platformyerlestir();
        }
    }
    void platformuret()
    {
        platformposition = new Vector2(0, 0);
        playerposition = new Vector2(0, 0.5f);
        GameObject player = Instantiate(playerprefab, playerposition, Quaternion.identity);

        GameObject ilkplatform = Instantiate(platformprefab, platformposition, Quaternion.identity);
        player.transform.parent = ilkplatform.transform;
        platforms.Add(ilkplatform);
        sonrakiplatformposition();
        ilkplatform.GetComponent<platform>().Hareket = true;
        for (int i = 0; i < 8; i++)
        {
            GameObject platform = Instantiate(platformprefab, platformposition, Quaternion.identity);
            platforms.Add(platform);
            platform.GetComponent<platform>().Hareket = true;
            if(i%2==0)
            {
                platform.GetComponent<altin>().altinac();
            }
            sonrakiplatformposition();
        }
        GameObject olumculplatforms = Instantiate(olumculplatformprefab, platformposition, Quaternion.identity);
        olumculplatforms.GetComponent<olumculplatform>().Hareket = true;
        platforms.Add(olumculplatforms);
        sonrakiplatformposition();
    }
    void platformyerlestir()
        {
        for (int i = 0; i < 5; i++)
        {
            GameObject temp;
            temp = platforms[i + 5];
            platforms[i + 5] = platforms[i];
            platforms[i] = temp;
            platforms[i + 5].transform.position = platformposition;
            if(platforms[i+5].gameObject.tag=="platform")
            {
                platforms[i + 5].GetComponent<altin>().altinkapa();
                float rastgelealtin = Random.Range(0.0f, 1.0f);
                if(rastgelealtin>0.5)
                {
                    platforms[i + 5].GetComponent<altin>().altinac();
                }
                   
            }
            sonrakiplatformposition();
        }
    }
    void sonrakiplatformposition()
    {
        platformposition.y += platformarasimesafe;

        siralipozisyon();
        
    }
    void karmapozisyon()
      {
        float random = Random.Range(0.0f, 1.0f);
        if (random < 0.5f)
        {
            platformposition.x = ekranhesaplayicisi.instance.Genislik / 2;

        }
        else
        {
            platformposition.x = -ekranhesaplayicisi.instance.Genislik / 2;
        }

    }
    bool yon = true;
    void siralipozisyon()
    {
        if(yon)
        {
            platformposition.x = ekranhesaplayicisi.instance.Genislik / 2;
            yon = false;
        }
        else
        {
            platformposition.x = -ekranhesaplayicisi.instance.Genislik / 2;
            yon = true;
        }
    }
}
