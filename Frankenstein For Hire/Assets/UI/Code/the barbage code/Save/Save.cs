using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class Save : MonoBehaviour
{
   public static void SaveData (Player player)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.Helpme";
        FileStream stream = new FileStream(path, FileMode.Create);

        PlayerData data = new PlayerData(player);

        formatter.Serialize(stream, data);
        stream.Close();

    }
    public static PlayerData LoadData ()
    {
        string path = Application.persistentDataPath + "/player.Helpme";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            PlayerData data = formatter.Deserialize(stream) as PlayerData;
            stream.Close();
            return data;
        }
        else
        {
            Debug.LogError("SaveFile not found in " + path);
            return null;
        }
    }
}
