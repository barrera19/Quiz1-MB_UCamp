using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Opportunities : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject opp1, used1;
    public int newPoints = 25;
    public bool lastChance = true;

    public void ActiveQLost()
        {
            print("Estoy Llamadando a la segunda OPP" + gameManager.active.opp);
            if(lastChance)
            {
                 opp1.SetActive(false);
                 used1.SetActive(true);
                 if(gameManager.active.countQuestions == 0)
                {
                 gameManager.random.question[gameManager.random.numRandom[gameManager.active.countQuestions]].SetActive(true);
                 lastChance = false;
                 gameManager.active.puntaje.text = gameManager.active.points.ToString();

                }
                else{
                    gameManager.random.question[gameManager.random.numRandom[gameManager.active.countQuestions]].SetActive(true);
                    lastChance = false;
                    gameManager.active.puntaje.text = gameManager.active.points.ToString();
                }

            }
                        
        }
}

