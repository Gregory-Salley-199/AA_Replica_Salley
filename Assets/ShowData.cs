using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowData : MonoBehaviour
{
    public Text PlayerName;
    public Text PlayerScore;
    public Text HighScore;
    public Text Rounds;

    private void Awake()
    {
       PlayerName.text = "Player Name: " + KeepData.PlayerName;
        HighScore.text = "High: " + KeepData.HighScore.ToString();
        Rounds.text = "Rounds: " + KeepData.Rounds.ToString();
    }
    private void Update()
    {
        PlayerScore.text = Score.PinCount.ToString();
    }
}
