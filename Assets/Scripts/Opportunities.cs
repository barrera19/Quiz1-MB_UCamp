using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Opportunities : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject opp1, opp2, used1, used2;
    public int newPoints = 25;

    public void countOpportunities()
    {
        if(gameManager.active.countOpp == 2)
        {
            opp2.SetActive(false);
            used2.SetActive(true);
            gameManager.random.question[gameManager.random.numRandom[gameManager.active.countQuestions-1]].SetActive(true);
            gameManager.active.countOpp--;
            gameManager.active.points = gameManager.active.points -newPoints;

        }
        if(gameManager.active.countOpp == 1)
        {
            opp1.SetActive(false);
            used1.SetActive(true);
            gameManager.active.points = gameManager.active.points -newPoints;
            gameManager.active.countOpp--;
            gameManager.random.question[gameManager.random.numRandom[gameManager.active.countQuestions-1]].SetActive(false);
            gameManager.random.question[gameManager.random.numRandom[gameManager.active.countQuestions]].SetActive(true);
            gameManager.active.ActiveQuestions();
        }
        if(gameManager.active.countOpp == 0)
        {
            opp1.SetActive(true);
            used1.SetActive(false);
            opp1.SetActive(true);
            used1.SetActive(false);
            gameManager.active.countOpp--;
            gameManager.active.ActiveQuestions();
        }

        
    }

    public void ActiveQLost()
        {
            print("Estoy Llamadando a la segunda OPP" + gameManager.active.countOpp);
        }
    
}
