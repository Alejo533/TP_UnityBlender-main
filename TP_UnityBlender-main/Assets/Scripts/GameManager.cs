using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class GameManager : MonoBehaviour
{
    private float timer = 60f;
    private UIManager uiManager;
    private bool gameOver = false; 

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
        }

        uiManager.UpdateTimer(timer);
    }

    public void ReiniciarJuego()
    {
        gameOver = true;
    }
}