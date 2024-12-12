using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public void SaveData()
    {
        Save.SaveData(this);
    }
    public void LoadData ()
    {
        PlayerData data = Save.LoadData();
        //shove the data here so
    }
}
