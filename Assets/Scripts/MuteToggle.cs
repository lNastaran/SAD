﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Toggle))]
public class MuteToggle : MonoBehaviour
{
    Toggle myToggle;
    // Start is called before the first frame update
    void Start()
    {
        myToggle = GetComponent<Toggle>();
        if (AudioListener.volume == 0)
        {
            myToggle.isOn = true;
        }
    }
    public void ToglleAudioOnValueChange(bool audioIn)
    {
        if (audioIn)
        {
            AudioListener.volume = 0;
        }
        else
        {
            AudioListener.volume = 1;
        }
    }
}