using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tamekran : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        Vector2 tempscale = transform.localScale;
        float spritegenislik = spriteRenderer.size.x;
        float ekranyukseklik = Camera.main.orthographicSize * 2.0f;
        float ekrangenislik = ekranyukseklik / Screen.height * Screen.width;
        tempscale.x = ekrangenislik / spritegenislik;
        transform.localScale = tempscale;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
