using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class AudioManager : MonoBehaviour
{
    [Header("Audio Source")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SfxSource;

    [Header("Audio Clip")]
    public AudioClip Bkgmusic;
    public AudioClip sfx;
    public AudioClip sfx2;
    public AudioClip sfx3;
    public AudioClip sfx4;

    public static AudioManager instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
        
   
        
    private void Start()
    {
        musicSource.clip = Bkgmusic;
        musicSource.Play();
    }
    public void PlaySFX(AudioClip clip)
    {
        SfxSource.PlayOneShot(clip);
    }
}
