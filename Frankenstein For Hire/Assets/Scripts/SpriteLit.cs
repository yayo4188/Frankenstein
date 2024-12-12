using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Sprites", order = 1)]
public class SpriteLit : ScriptableObject
{
    public Sprite[] EmoteList = new Sprite[0];
    public Sprite EmptySprite;

    public Sprite GetByName(string eName)
    {
        foreach (var sprite in EmoteList)
        {
            if (sprite.name == eName) return sprite;
        }
        Debug.LogWarning($"Failed to find sprite {eName}");
        return EmptySprite;


    }
   
    
}
