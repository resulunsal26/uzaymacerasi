using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class altin : MonoBehaviour
{
    [SerializeField]
    GameObject altinobje = default;
    public void altinac()
    {
        altinobje.SetActive(true);
    }
    public void altinkapa()
    {
        altinobje.SetActive(false);
    }
}
