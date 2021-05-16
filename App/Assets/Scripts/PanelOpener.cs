using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelOpener : MonoBehaviour
{
	public GameObject Panel;
    public GameObject arrowUp;
    public GameObject arrowDown;
    
    public void openPanel()
    {
    	if (Panel != null)
    	{
    		Animator animator = Panel.GetComponent<Animator>();

    		if (animator != null)
    		{
    			bool isOpen = animator.GetBool("open");
    			animator.SetBool("open", !isOpen);

                if (isOpen)
                {
                    arrowUp.SetActive(false);
                    arrowDown.SetActive(true);
                }
                else
                {
                    arrowUp.SetActive(true);
                    arrowDown.SetActive(false);
                }
    		}
    	}
    }
}
