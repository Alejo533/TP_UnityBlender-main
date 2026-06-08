using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TMP_Text score;
    public TMP_Text timer;

    public GameObject gameOverPanel;
    public GameObject winPanel;

    void Start()
    {
        gameOverPanel.SetActive(false);
        winPanel.SetActive(false);
    }

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
        gameOverPanel.SetActive(true);
    }

    public void ShowWin()
    {
        winPanel.SetActive(true);
    }
}
