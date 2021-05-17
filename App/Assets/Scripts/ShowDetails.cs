using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowDetails : MonoBehaviour
{
	public GameObject details;

    public void showDetails() 
    {
        details.SetActive(true);    
    }

    public void hideDetails()
    {
    	details.SetActive(false);
    }
}
