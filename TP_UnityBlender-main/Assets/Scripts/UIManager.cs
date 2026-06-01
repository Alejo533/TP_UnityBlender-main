using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{

    public TMP_Text score;
    public TMP_Text timer;
    public GameObject gameOvertext;

    public void UpdateScore(int newscore)
    {
        score.text = "Score: " + newscore;
    }

    public void UpdateTimer(float newtime)
    {
        timer.text = "Tiempo: " + Mathf.Ceil(newtime);
    }

    public void ShowGameOver()
    {
        gameOvertext.SetActive(true);
    }
}
