using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MapOpen : MonoBehaviour
{
	public GameObject Map;
    public GameObject MapButton;
    public GameObject Arrow;
    public GameObject Dimmer;    
    public void openMap()
    {
    	if (Map != null)
    	{
    		Animator animator = Map.GetComponent<Animator>();
            
    		if (animator != null)
    		{
    			bool isOpen = animator.GetBool("open");
    			animator.SetBool("open", !isOpen);

                if(isOpen)
                {
                    MapButton.SetActive(true);
                    Arrow.SetActive(false);
                    Dimmer.SetActive(false);
                }
                else
                {
                    MapButton.SetActive(false);
                    Arrow.SetActive(true);
                    Dimmer.SetActive(true);
                }
    		}
    	}
    }
}
