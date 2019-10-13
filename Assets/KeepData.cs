using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class KeepData : MonoBehaviour
{
    public static string PlayerName = "Unknown";
    public static int PlayerScore;
    public static int HighScore = 0;
    public static int Rounds = 0;

    public InputField GetPlayerName;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject); 
    }
    public void UpdateName()
    {
        PlayerName = GetPlayerName.text;
    }
}
