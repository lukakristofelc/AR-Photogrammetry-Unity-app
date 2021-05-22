using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using SimpleJSON;
using TMPro;

public class PanelOpener : MonoBehaviour
{
	public GameObject Panel;

    public GameObject openPanelButton;
    public GameObject closePanelButton;
    public TMP_Text naslov;
    public TMP_Text izdelava;
    public TMP_Text kipar;
    public TMP_Text posebnosti;
    
    public void openPanel()
    {
        Debug.Log (PlayerPrefs.GetString("statue"));
        Debug.Log(Application.dataPath);
        string text = Resources.Load<TextAsset>("JSON/Kipi").text;
        //string jsonString = File.ReadAllText (Application.dataPath+"/Scripts/Kipi.json"); 
        JSONNode data = JSON.Parse(text);
        foreach(JSONNode kip in data["Kipi"])
        {
            if (PlayerPrefs.GetString("statue") == kip["Naslov"].Value)
            {
                naslov.text = kip["Naslov"].Value;
                izdelava.text = kip["Izdelava"].Value;
                kipar.text = kip["Kipar"].Value;
                posebnosti.text = kip["Posebnosti"].Value;
            }
        }

    	if (Panel != null)
    	{
    		Animator animator = Panel.GetComponent<Animator>();
            
    		if (animator != null)
    		{
    			bool isOpen = animator.GetBool("open");
    			animator.SetBool("open", !isOpen);

                if (isOpen)
                {
                    openPanelButton.SetActive(true);
                    closePanelButton.SetActive(false);
                }
                else
                {
                    openPanelButton.SetActive(false);
                    closePanelButton.SetActive(true);
                }
    		}
    	}
    }
}
