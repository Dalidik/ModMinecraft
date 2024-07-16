using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class DownloadManager : MonoBehaviour
{
    public float ReminingTime;
    public Slider Slider;

    private bool _timerStart;

    private void Update()
    {
        if (_timerStart!)
        {
            Time.timeScale = 1;
            Slider.value = ReminingTime += Time.deltaTime;
        }
    }

    public void StartTimer()
    {
        ReminingTime = 0f;
        _timerStart = true;
    }
}
