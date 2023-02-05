using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class ActiveQuestion : MonoBehaviour
{

    public GameManager gameManager;
    public int countQuestions = 0;
    public int points = 0;
    public TextMeshProUGUI puntaje;
    public int countOpp = 2;
    
    public void ActiveQuestions()
    {       

        if(countQuestions != 0)
        {
          gameManager.random.question[gameManager.random.numRandom[countQuestions]].SetActive(false);
          countQuestions++;
          if(countQuestions == gameManager.random.question.Length - 1)
          {
            print("entre al final");
            gameManager.random.question[gameManager.random.numRandom[countQuestions-1]].SetActive(false);
            gameManager.lastQ.LastQ();
          }
          else
          {
            gameManager.random.question[gameManager.random.numRandom[countQuestions]].SetActive(true);
          }
          
        }
        else
        {
            gameManager.random.question[gameManager.random.numRandom[0]].SetActive(false);
            countQuestions++; 
            gameManager.random.question[gameManager.random.numRandom[countQuestions]].SetActive(true);
        }
        if(countOpp < 0)
        {
          countOpp = 2;
        }
        puntaje.text = points.ToString();
        
        
    }

    public void CorrectAnswer(Button button)
    {
        StartCoroutine(AnswerColorCorrect(button));
        gameManager.bloqueo.BloqueoPantalla();
        
        
    }

    public void IncorrectAnwser(Button button)
    {
        
        StartCoroutine(AnswerColorIncorrect(button));
        button.image.color = Color.red;
        gameManager.bloqueo.BloqueoPantalla();
        
    }

   public IEnumerator AnswerColorCorrect(Button button)
    {
        points = points + 100;
        button.image.color = Color.green;
        yield return new WaitForSeconds(1);
        AnswerReset(button);
        ActiveQuestions();
        
    }

     public IEnumerator AnswerColorIncorrect(Button button)
    {
        button.image.color = Color.red;
        yield return new WaitForSeconds(0.5f);
        AnswerReset(button);
        points = points - gameManager.opp.newPoints;
        countOpp--;
        gameManager.opp.ActiveQLost();
        ActiveQuestions();
        
    }

     public void AnswerReset(Button button)
     { 
        Color32 colorReset = new Color(255f, 255f, 255f);
        button.image.color = colorReset;
        gameManager.bloqueo.DesBloqueoPantalla();
        new WaitForSeconds(1);


     }

}
