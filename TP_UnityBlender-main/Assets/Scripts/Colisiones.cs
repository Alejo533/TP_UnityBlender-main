using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisiones : MonoBehaviour
{
    private int score = 0;
    private UIManager uiManager;
    private GameManager gameManager;

    void Start()
    {
        uiManager = FindObjectOfType<UIManager>();
        gameManager = FindObjectOfType<GameManager>();
        uiManager.UpdateScore(score);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coleccionable"))
        {
            score = score + 1;

            uiManager.UpdateScore(score);

            Debug.Log("Colision con " + other.gameObject.name);

            Destroy(other.gameObject);

            if (score == 5){
                gameManager.ReiniciarJuego();
                uiManager.ShowWin();
                Time.timeScale = 0;
            }
        }
    }
}
