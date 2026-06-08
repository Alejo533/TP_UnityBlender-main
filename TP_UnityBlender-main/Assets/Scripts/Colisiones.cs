using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisiones : MonoBehaviour
{
    private int score = 0;
    private UIManager uiManager;

    void Start()
    {
        uiManager = FindObjectOfType<UIManager>();
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
        }
    }
}
