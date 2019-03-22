using System.Collections;
using UnityEngine;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public static class SaveLoad
{
    public static string Level = "Intro";

    public static void Save (string level)
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/savedGames.youlilhacker");
        bf.Serialize(file ,level );
        file.Close();
    }
    public static void Load ()
    {
        if (File.Exists(Application.persistentDataPath + "/savedGames.youlilhacker"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/savedGames.youlilhacker",FileMode.Open);
            SaveLoad.Level = (string)bf.Deserialize(file);
        }
    }
}
