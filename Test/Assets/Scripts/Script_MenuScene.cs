﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Script_MenuScene : MonoBehaviour
{
    public void OnPushPlayButton()
    {
        SceneManager.LoadScene("ChoixPersoScene");
    }

    public void OnPushQuitButton()
    {
        Application.Quit();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
