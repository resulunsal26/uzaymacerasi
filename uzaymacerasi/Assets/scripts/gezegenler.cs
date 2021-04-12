using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gezegenler : MonoBehaviour
{
    List<GameObject> gezegenlers = new List<GameObject>();
    List<GameObject> kullanilangezegenler = new List<GameObject>();
    private void Awake()
    {
        Object[] sprites = Resources.LoadAll("Gezegenler");
        for (int i = 1; i < 17; i++)
        {
            GameObject gezegen = new GameObject();
            SpriteRenderer spriteRenderer = gezegen.AddComponent<SpriteRenderer>();
            spriteRenderer.sprite =(Sprite) sprites[i];
            Color spritecolor = spriteRenderer.color;
            spritecolor.a = 0.5f;
            spriteRenderer.color = spritecolor;
            gezegen.name = sprites[i].name;
            spriteRenderer.sortingLayerName = "gezegen";
            Vector2 pozisyon = gezegen.transform.position;
            pozisyon.x = -10;
            gezegen.transform.position = pozisyon;
            gezegenlers.Add(gezegen);
        }
    }

  public void gezegenyerlestir(float refy)
    {
        float yukseklik = ekranhesaplayicisi.instance.Yukseklik;
        float genislik = ekranhesaplayicisi.instance.Genislik;
        //1.bölge
        float xdegerbir =Random.Range(0.0f,genislik);
        float ydegerbir =Random.Range( refy ,refy+ yukseklik);
        GameObject gezegenbir = randomgezegen();
        gezegenbir.transform.position = new Vector2(xdegerbir, ydegerbir);
        //2.bölge
        float xdeger2 = Random.Range(-genislik, 0.0f);
        float ydeger2 = Random.Range(refy, refy + yukseklik);
        GameObject gezegen2 = randomgezegen();
        gezegen2.transform.position = new Vector2(xdeger2, ydeger2);
        //3.bölge
        float xdeger3 = Random.Range(-genislik, 0.0f);
        float ydeger3 = Random.Range(refy-yukseklik , refy);
        GameObject gezegen3= randomgezegen();
        gezegen3.transform.position = new Vector2(xdeger3, ydeger3);
        //4.bölge
        float xdeger4 = Random.Range(0.0f, genislik);
        float ydeger4 = Random.Range(refy - yukseklik, refy);
        GameObject gezegen4 = randomgezegen();
        gezegen4.transform.position = new Vector2(xdeger4, ydeger4);

    }
    GameObject randomgezegen()
    {
        if(gezegenlers.Count>0)
        {
            int random;
            if(gezegenlers.Count==1)
            {
                random = 0;
            }
            else
            {
                random = Random.Range(0, gezegenlers.Count - 1);
            }
            GameObject gezegen = gezegenlers[random];
            gezegenlers.Remove(gezegen);
            kullanilangezegenler.Add(gezegen);
            return gezegen;

        }
        else
        {
            for (int i = 0; i < 8; i++)
            {
                gezegenlers.Add(kullanilangezegenler[i]);
            }
            kullanilangezegenler.RemoveRange(0, 8);
            int    random = Random.Range(0, gezegenlers.Count - 1);
            GameObject gezegen = gezegenlers[random];
            gezegenlers.Remove(gezegen);
            kullanilangezegenler.Add(gezegen);
            return gezegen;
        }
    }
}
