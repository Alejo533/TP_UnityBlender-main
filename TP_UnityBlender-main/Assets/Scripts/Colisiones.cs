using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisiones : MonoBehaviour
{
    private int score = 0;
    private UIManager uiManager;
    private GameManager gameManager;
    public GameObject score1;
    public GameObject panel;
    public GameObject panel1;
    public GameObject timer1;
    public GameObject panel2;
    public GameObject panel3;

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
                score1.SetActive(false);
                panel.SetActive(false);
                panel1.SetActive(false);
                timer1.SetActive(false);
                panel2.SetActive(false);
                panel3.SetActive(false);
            }
        }
    }
}
