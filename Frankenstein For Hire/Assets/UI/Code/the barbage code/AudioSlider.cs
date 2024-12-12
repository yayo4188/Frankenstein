using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Audioslider : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    void Start()
    {
        if(!PlayerPrefs.HasKey("musicVolume"))
        {
            PlayerPrefs.SetFloat("musicVolume", 1);
            load();
        }
    }
    public void ChangeVolume()
    {
        AudioListener.volume = volumeSlider.value;

    }
    private void load()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("musicVolume");

    }
    private void save()
    {
        PlayerPrefs.SetFloat("musicVolume", volumeSlider.value);
    }
}
