using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ekrandatut : MonoBehaviour
{
    BoxCollider2D box;
   
    
    void Update()
    {
        if(transform.position.x< -ekranhesaplayicisi.instance.Genislik)
        {
            Vector2 temp = transform.position;
            temp.x = -ekranhesaplayicisi.instance.Genislik;
            transform.position = temp;
        }
        else if (transform.position.x > ekranhesaplayicisi.instance.Genislik)
        {
            Vector2 temp = transform.position;
            temp.x = ekranhesaplayicisi.instance.Genislik;
            transform.position = temp;
        }
    }
}
