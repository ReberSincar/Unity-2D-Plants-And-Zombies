using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSettings : MonoBehaviour
{
    const string VOLUME_LEVEL_KEY = "volume";
    const string GAME_LEVEL_KEY = "game_level";
    const string DIFFICULTY_LEVEL = "difficulty_level";
    const string IS_FIRST_OPEN = "first_open";

    public static void SetVolumeLevel(float volume) {
        PlayerPrefs.SetFloat(key: VOLUME_LEVEL_KEY, volume);
    }

    public static float GetVolumeLevel() {
        return PlayerPrefs.GetFloat(key: VOLUME_LEVEL_KEY);
    }

    public static void SetGameLevel(int level)
    {
        PlayerPrefs.SetInt(key: GAME_LEVEL_KEY, level);
    }

    public static float GetGameLevel()
    {
        return PlayerPrefs.GetInt(key: VOLUME_LEVEL_KEY);
    }

    public static void SetDifficultyLevel(int difficulty)
    {
        PlayerPrefs.SetInt(key: DIFFICULTY_LEVEL, difficulty);
    }

    public static float GeDifficultyLevel()
    {
        return PlayerPrefs.GetInt(key: DIFFICULTY_LEVEL);
    }

    public static void SetFirstOpen(bool isFirst)
    {
        PlayerPrefs.SetInt(key: IS_FIRST_OPEN, isFirst ? 1:0);
    }

    public static bool GetFirstOpen()
    {
        return PlayerPrefs.GetInt(key: IS_FIRST_OPEN) == 1;
    }
}
