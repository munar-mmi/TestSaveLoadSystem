using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class LevelData
{
    public int levelID;
    public int levelScore;
    public bool isComplete;

    public LevelData(Level level)
    {
        levelID = level.levelID;
        levelScore = level.levelScore;
        isComplete = level.isComplete;
    }
}
