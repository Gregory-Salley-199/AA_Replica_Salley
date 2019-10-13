using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int PinCount;

    public Text text;

    void Start()
    {
        PinCount = 0;
    }

    void Update()
    {
        KeepData.PlayerScore = PinCount;
        text.text = PinCount.ToString();
        // can't use panelscoretext here because we did not declare the text at the top, look at showdata script.
    }
}