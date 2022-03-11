using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    public int levelID;
    public int levelScore;
    public bool isComplete;


    public void SaveLevel()
    {
        SaveSystem.SaveData(this);
    }

    public void LoadLevel()
    {
        LevelData data = SaveSystem.LoadData(this);

        levelID = data.levelID;
        levelScore = data.levelScore;
        isComplete = data.isComplete;
    }
}
