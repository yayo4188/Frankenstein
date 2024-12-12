using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Yarn.Unity;
using Image = UnityEngine.UI.Image;

public class DialogueSpriteDisplayer : MonoBehaviour
///For sprite display: takes name of character sprite and placement (left, middle, right) to search for sprite and display it.

{
   // public Sprite EmptySprite;
   
    
    public SpriteLit Sprites;

    public void Start()
    {
        SpriteClear();

    }


    [YarnCommand("spriteEmote")] 
    public void SpriteEmote(string emoteName)
    {
        GetComponent<Image>().enabled = true;
        GetComponent<Image>().sprite = Sprites.GetByName(emoteName);
        

    }

    [YarnCommand ("spriteClear")]
    public void SpriteClear()
    {
        GetComponent<Image>().enabled = false;
    }

}
