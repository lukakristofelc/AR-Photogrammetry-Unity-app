using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitchScript : MonoBehaviour
{
    public void GoToMenu()
    {
    	SceneManager.LoadScene(0);
    }

    public void GoToARScene() 
    {
    	SceneManager.LoadScene(1);
    }
}
