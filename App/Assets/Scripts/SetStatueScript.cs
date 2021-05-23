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
        PlayerPrefs.SetString("statue", "Franc Ksaver Meško");
    }

    public void Kip4()
    {
        PlayerPrefs.SetString("statue", "Kip Mathatme Gandhija");
    }

    public void Kip5()
    {
        PlayerPrefs.SetString("statue", "Spomenik Radu Iršiču");
    }

    public void Kip6()
    {
        PlayerPrefs.SetString("statue", "Bellosics Bálint");
    }
}
