using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetStatueScript : MonoBehaviour
{
    public void Kip1()
    {
    	PlayerPrefs.SetString("statue", "Evridika");
    }

    public void Kip2()
    {
        PlayerPrefs.SetString("statue", "Balet");
    }

    public void Kip3()
    {
        PlayerPrefs.SetString("statue", "Mesko");
    }

    public void Kip4()
    {
        PlayerPrefs.SetString("statue", "Gandhi");
    }

    public void Kip5()
    {
        PlayerPrefs.SetString("statue", "Gregl");
    }

    public void Kip6()
    {
        PlayerPrefs.SetString("statue", "Bellosics");
    }
}
