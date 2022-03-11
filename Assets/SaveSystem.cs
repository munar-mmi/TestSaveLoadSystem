using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{
    public static LevelData[] levelsData;  

    public static void SaveData(Level level)
    {
        levelsData[level.levelID - 1] = new LevelData(level);

        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/LevelsSave.bin";
        FileStream fs = new FileStream(path, FileMode.Create);

        formatter.Serialize(fs, levelsData);
        fs.Close();
    }

    public static LevelData LoadData(Level level)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/LevelsSave.bin";
        FileStream fs = new FileStream(path, FileMode.Open);

        levelsData = (LevelData[])formatter.Deserialize(fs);
        fs.Close();

        return levelsData[level.levelID - 1];
    }
}
