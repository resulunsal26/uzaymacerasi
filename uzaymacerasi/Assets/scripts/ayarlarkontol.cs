using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ayarlarkontol : MonoBehaviour
{
    public Button kolaybtn, ortabtn, zorbtn;
    
    void Start()
    {
        if(secenekler.kolaydegeroku()==1)
        {
            kolaybtn.interactable = false;
            ortabtn.interactable = true;
            zorbtn.interactable = true;
        }
        if (secenekler.ortadegeroku() == 1)
        {
            kolaybtn.interactable = true;
            ortabtn.interactable = false;
            zorbtn.interactable = true;
        }
        if(secenekler.zordegeroku()==1)
        {
            kolaybtn.interactable = true;
            ortabtn.interactable = true;
            zorbtn.interactable = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void seceneksecildi(string seviye)
    {
        switch (seviye)
        {
            case "kolay":
                secenekler.kolaydegerata(1);
                secenekler.ortadegerata(0);
                secenekler.zordegerata(0);
                kolaybtn.interactable = false;
                ortabtn.interactable = true;
                zorbtn.interactable = true;
                    break;
            case "orta":
                secenekler.kolaydegerata(0);
                secenekler.ortadegerata(1);
                secenekler.zordegerata(0);
                kolaybtn.interactable = true;
                ortabtn.interactable = false;
                zorbtn.interactable = true;
                break;
            case "zor":
                secenekler.kolaydegerata(0);
                secenekler.ortadegerata(0);
                secenekler.zordegerata(1);
                kolaybtn.interactable = true;
                ortabtn.interactable = true;
                zorbtn.interactable = false;
                break;
        }
    }
    public void anamenu()
    {
        SceneManager.LoadScene("menuscene");
    }
}
