using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ColliderChecker : MonoBehaviour
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

  

    private void OnTriggerEnter(Collider other)
    {

        Limb = other.gameObject.tag;
        Debug.Log(Limb);
        Roll = Random.Range(1, 4);
        if (Roll == 1)
        {
            audioSource1.PlayOneShot(clip1, volume);
        }
        else if (Roll == 2)
        {
            audioSource2.PlayOneShot(clip2, volume);
        }
        else if (Roll == 3)
        {
            audioSource3.PlayOneShot(clip3, volume);
        }
        else if (Roll == 4)
        {
            audioSource4.PlayOneShot(clip4, volume);
        }
      
    }
}
