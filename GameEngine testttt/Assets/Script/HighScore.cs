using UnityEngine;

public class HighScore : MonoBehaviour
{
    private const string KEY = "HighScore";
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    public static int Load(int stage)
    {
        return PlayerPrefs.GetInt(KEY + "_" + stage, 0);
    }

    public static void TrySet(int stage, int newScore)
    {
        if (newScore <= Load(stage))
        {
            return;
        }
        PlayerPrefs.SetInt(KEY + "_" + stage, newScore);
        PlayerPrefs.Save();
    }
}
