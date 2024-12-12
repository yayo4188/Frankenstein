using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class DialogueSound : MonoBehaviour
{

    public string Limb;

    //sound effect stuff 
    public AudioSource audioSource1;
    public AudioSource audioSource2;
    public AudioSource audioSource3;
    public AudioSource audioSource4;
    public float volume = 0.5f;

    int Roll;


    //sound effect
    public AudioClip clip1;
    public AudioClip clip2;
    public AudioClip clip3;
    public AudioClip clip4;



    [YarnCommand("Sound")]
    public void SpriteEmote(string SoundName)
    {

        if (SoundName == "bk1")
        {
            audioSource1.PlayOneShot(clip1, volume);
        }
        else if (SoundName == "bk2")
        {
            audioSource2.PlayOneShot(clip2, volume);
        }
        

    }

}
