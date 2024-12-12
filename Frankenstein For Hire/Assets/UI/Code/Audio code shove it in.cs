using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audiocodeshoveitin : MonoBehaviour
{
    //shove this at the start of the script
    AudioManager audiomanager;
    private void Awake()
    {
        audiomanager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }
    //  shove this where the audio is supposed to play audiomanager.PlaySFX(audiomanager."Whatever slot you assigned the audio to");

}
