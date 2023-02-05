using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishGame : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject finalizaJuego;

    public void endGame()
    {
        gameManager.random.question[gameManager.random.numRandom[gameManager.active.countQuestions]].SetActive(false);
        gameManager.final.FinalScreen();
    }
}
