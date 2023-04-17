using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioControl : MonoBehaviour
{
    public AudioMixerGroup Mixer;
    [SerializeField] private Sprite _soundNo;
    [SerializeField] private Sprite _soundYes;
    [SerializeField] private Button _soundButton;
    private bool _isAudio;
    private int _picture;

    private void FixedUpdate()
    {
        if (_isAudio == true)
        {
            Mixer.audioMixer.SetFloat("MusicVolume", 0);
            _soundButton.image.sprite = _soundYes;
        }
        else if (_isAudio == false)
        {
            Mixer.audioMixer.SetFloat("MusicVolume", -80);
            _soundButton.image.sprite = _soundNo;
        }
    }

    private void SwitchAudioStatus(bool status)
    {
        _isAudio = status ? true : false;
        _isAudio = !status;
        _picture = status ? 1 : 0;
        
        PlayerPrefs.SetInt("MusicEnabled", status ? 1 : 0);
        PlayerPrefs.SetInt("Picture", status ? 1 : 0);
    }

    public void AudioButton()
    {
        SwitchAudioStatus(_isAudio);
        Debug.Log(_isAudio);
    }
}
