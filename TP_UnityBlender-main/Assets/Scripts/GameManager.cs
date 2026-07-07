using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class GameManager : MonoBehaviour
{
    private float timer = 60f;
    private UIManager uiManager;
    private bool gameOver = false; 
    public GameObject score;
    public GameObject panel;
    public GameObject panel1;
    public GameObject timer1;
    public GameObject panel2;
    public GameObject panel3;

    void Start()
    {
        Time.timeScale = 1; 
        uiManager = FindObjectOfType<UIManager>();
    }

    void Update()
    {      

        if (gameOver && Input.GetKeyDown(KeyCode.R))
        {
            Time.timeScale = 1;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if (gameOver) return;

        timer -= Time.deltaTime;

        if (timer < 0)
        {
            timer = 0;
            gameOver = true;
            uiManager.ShowGameOver();
            Time.timeScale = 0;
            score.SetActive(false);
            panel.SetActive(false);
            panel1.SetActive(false);
            timer1.SetActive(false);
            panel2.SetActive(false);
            panel3.SetActive(false);
        }

        uiManager.UpdateTimer(timer);
    }

    public void ReiniciarJuego()
    {
        gameOver = true;
    }
}