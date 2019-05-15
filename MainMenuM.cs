﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuM : MonoBehaviour
{
    public int Ready;
    private void Start()
    {
        Ready = 4;
        Singleton.instance.Start_rank();
    }
    private void Update()
    {
        if (Singleton.instance.Ready == Ready)
        {
            Singleton.instance.Reset_Ready();
            Singleton.instance.Send_TeamMSG();
            SceneManager.LoadScene("Map");
        }
    }
}
