using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishGame : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject finalizaJuego;

    public void endGame()
    {
        if(gameManager.active.countQuestions == 0) 
        {
        gameManager.active.countQuestions++;
        }
        gameManager.random.question[gameManager.random.numRandom[gameManager.active.countQuestions-1]].SetActive(false);
        gameManager.final.FinalScreen();
    }
}
