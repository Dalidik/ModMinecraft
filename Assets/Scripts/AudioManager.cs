using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public Sprite NotMutedImage;
    public Sprite MutedImage;
    
    [SerializeField]
    private AudioSource _audioSource;
    private Button _button;
    private bool _muted;

    private void Start()
    {
        _button = GetComponent<Button>();

        if (!PlayerPrefs.HasKey("muted"))
        {
            PlayerPrefs.SetInt("muted", 0);
            Load();
        }
        else
        {
            Load();
        }

        _audioSource.mute = _muted;

        if (_muted)
            _button.image.sprite = MutedImage;
        else
            _button.image.sprite = NotMutedImage;
    }

    public void OnButtonPress()
    {
        if (_muted)
        {
            _muted = false;
            _audioSource.mute = false;
            _button.image.sprite = NotMutedImage;
        }
        else
        {
            _muted = true;
            _audioSource.mute = true;
            _button.image.sprite = MutedImage;
        }

        Save();
    }

    private void Load()
    {
        _muted = PlayerPrefs.GetInt("muted") == 1;
    }

    private void Save()
    {
        PlayerPrefs.SetInt("muted", _muted ? 1 : 0);
    }
}
