using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sliderkontrol : MonoBehaviour
{
    Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();
        slider.value = 1.0f;
    }

    public void Sliderdeger(int maxdeger,int gecerlideger)
    {
        int sliderdeger = maxdeger - gecerlideger;
        slider.maxValue = maxdeger;
        slider.value = sliderdeger;
    }
}
