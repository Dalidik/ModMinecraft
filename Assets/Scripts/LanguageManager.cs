using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization.Settings;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class LanguageManager : MonoBehaviour
{
    public Sprite[] Sprites;
    public Button Button;

    private readonly string _key = "num";
    private int _num;

    private void Start()
    {
        _num = PlayerPrefs.GetInt(_key);
        SetImage();
    }

    public void English()
    {
        StartCoroutine(SetLanguage(0));
        _num = 0;
        PlayerPrefs.SetInt(_key, _num);
    }

    public void Polish()
    {
        StartCoroutine(SetLanguage(1));
        _num = 1;
        PlayerPrefs.SetInt(_key, _num);
    }

    public void Russian()
    {
        StartCoroutine(SetLanguage(2));
        _num = 2;
        PlayerPrefs.SetInt(_key, _num);
    }

    private IEnumerator SetLanguage(Int32 i)
    {
        _num = i;
        yield return LocalizationSettings.InitializationOperation;

        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[i];
    }

    private void SetImage()
    {
        if (_num == 0)
            Button.image.sprite = Sprites[0];
        else if (_num == 1)
            Button.image.sprite = Sprites[1];
        else if (_num == 2) Button.image.sprite = Sprites[2];
    }
}
