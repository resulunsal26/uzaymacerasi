using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class secenekler
{

    public static string kolay = "kolay";
    public static string orta = "orta";
    public static string zor = "zor";

    public static string kolaypuan = "kolaypuan";
    public static string ortapuan = "ortapuan";
    public static string zorpuan = "zorpuan";

    public static string kolayaltin = "kolayaltin";
    public static string ortaaltin = "ortaaltin";
    public static string zoraltin = "zoraltin";



    public static string muzikacik = "muzikacik";
    public static void kolaydegerata(int kolay)
    {
        PlayerPrefs.SetInt(secenekler.kolay,kolay);
    }
    public static int kolaydegeroku()
    {
        return PlayerPrefs.GetInt(secenekler.kolay);
    }
    public static void ortadegerata(int orta)
    {
        PlayerPrefs.SetInt(secenekler.orta, orta);
       
    }
    public static int ortadegeroku()
    {
        return PlayerPrefs.GetInt(secenekler.orta);
    }
    public static void zordegerata(int zor)
    {
        PlayerPrefs.SetInt(secenekler.zor, zor);
    }
    public static int zordegeroku()
    {
        return PlayerPrefs.GetInt(secenekler.zor);
    }




    public static void kolaypuandegerata(int kolaypuan)
    {
        PlayerPrefs.SetInt(secenekler.kolaypuan, kolaypuan);
    }
    public static int kolaypuandegeroku()
    {
        return PlayerPrefs.GetInt(secenekler.kolaypuan);
    }
    public static void ortapuandegerata(int ortapuan)
    {
        PlayerPrefs.SetInt(secenekler.ortapuan, ortapuan);

    }
    public static int ortapuandegeroku()
    {
        return PlayerPrefs.GetInt(secenekler.ortapuan);
    }
    public static void zorpuandegerata(int zorpuan)
    {
        PlayerPrefs.SetInt(secenekler.zorpuan, zorpuan);
    }
    public static int zorpuandegeroku()
    {
        return PlayerPrefs.GetInt(secenekler.zorpuan);
    }




    public static void kolayaltindegerata(int kolayaltin)
    {
        PlayerPrefs.SetInt(secenekler.kolayaltin, kolayaltin);
    }
    public static int kolayaltindegeroku()
    {
        return PlayerPrefs.GetInt(secenekler.kolayaltin);
    }
    public static void ortaaltindegerata(int ortaaltin)
    {
        PlayerPrefs.SetInt(secenekler.ortaaltin, ortaaltin);

    }
    public static int ortaaltindegeroku()
    {
        return PlayerPrefs.GetInt(secenekler.ortaaltin);
    }
    public static void zoraltindegerata(int zoraltin)
    {
        PlayerPrefs.SetInt(secenekler.zoraltin, zoraltin);
    }
    public static int zoraltindegeroku()
    {
        return PlayerPrefs.GetInt(secenekler.zoraltin);
    }


    public static void muzikacikdegerata(int muzikacik)
    {
        PlayerPrefs.SetInt(secenekler.muzikacik, muzikacik);
    }
    public static int muzikacikdegeroku()
    {
        return PlayerPrefs.GetInt(secenekler.muzikacik);
    }




    public static bool kayitvarmi()
    {
        if (PlayerPrefs.HasKey(secenekler.kolay) || PlayerPrefs.HasKey(secenekler.orta) || PlayerPrefs.HasKey(secenekler.zor))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public static bool muzikvarmi()
    {
        if (PlayerPrefs.HasKey(secenekler.muzikacik))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
