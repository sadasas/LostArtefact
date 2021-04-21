using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.Audio;

public class setVol : MonoBehaviour
{
    public AudioMixer mixer;
    public AudioMixer mixer2;
    public AudioMixer mixer3;
    public AudioMixer mixer4;
    public AudioMixer mixer5;
    public AudioMixer mixer6;

    public void SetLevel1(float sliderValue)
    {
        mixer.SetFloat("SFX1", Mathf.Log10(sliderValue) * 20);
    }

    public void SetLevel1bgm(float sliderValue)
    {
        mixer4.SetFloat("BGM1", Mathf.Log10(sliderValue) * 20);
    }

    public void SetLevel2(float sliderValue)
    {
        mixer2.SetFloat("SFX2", Mathf.Log10(sliderValue) * 20);
    }

    public void SetLevel2bgm(float sliderValue)
    {
        mixer3.SetFloat("BGM2", Mathf.Log10(sliderValue) * 20);
    }

    public void SetLevel3(float sliderValue)
    {
        mixer5.SetFloat("SFX3", Mathf.Log10(sliderValue) * 20);
    }

    public void SetLevel3bgm(float sliderValue)
    {
        mixer6.SetFloat("BGM3", Mathf.Log10(sliderValue) * 20);
    }
}