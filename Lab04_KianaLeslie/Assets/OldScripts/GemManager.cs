using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemManager
{
   public static List<LevelGems> Levels = new();
    public static void ResetLevels()
    {
        Levels.Clear();
        for(int levelIndex = 0; levelIndex < Levels.Count; levelIndex++)
        {
            LevelGems newLevel = new();
            newLevel.Level = levelIndex;
            newLevel.Gems = new bool[] { false, false, false };
        }
    }
}
public struct LevelGems
{
    public int Level;
    public bool[] gems;
    public bool[] Gems { get => Gems; set => gems = value; }
}