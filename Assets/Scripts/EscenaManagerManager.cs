using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscenaManager : MonoBehaviour
{

    public bool nextLevel;
    public int nameLevel;


   

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    public void ChangeScence(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void OnApplicationQuit()
    {
        Application.Quit();
    }
}
