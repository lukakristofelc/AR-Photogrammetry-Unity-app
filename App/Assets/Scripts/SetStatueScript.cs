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
        PlayerPrefs.SetString("statue", "Pan");
    }
}
