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
    public bool opp = true;
    
    public void ActiveQuestions()
    {       
         opp = true;
         gameManager.opp.opp1.SetActive(true);
         gameManager.opp.used1.SetActive(false);
         gameManager.questionCounter.counterQuestion();

        if(countQuestions != 0)
        {
          gameManager.random.question[gameManager.random.numRandom[countQuestions-1]].SetActive(false);
          
          if(countQuestions == gameManager.random.question.Length-1)
          {
            print("entre al final: Lenght: " + gameManager.random.question.Length);
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
          gameManager.random.question[gameManager.random.numRandom[0]].SetActive(true);
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
        points = points - gameManager.opp.newPoints;
        opp = false;
        
    }

   public IEnumerator AnswerColorCorrect(Button button)
    {
        button.image.color = Color.green;
        yield return new WaitForSeconds(1);
        AnswerReset(button);
        if(opp)
        {
        points = points + 100;
        countQuestions++;
        ActiveQuestions();
        }
        else
        {
          points = points + gameManager.opp.newPoints;
          countQuestions++;
          ActiveQuestions();
        }
        
        
    }

     public IEnumerator AnswerColorIncorrect(Button button)
    {
        button.image.color = Color.red;
        yield return new WaitForSeconds(0.5f);
        AnswerReset(button);
        puntaje.text = points.ToString();
        if(gameManager.opp.lastChance)
        { 
          if(countQuestions == 0)
          {
          gameManager.opp.ActiveQLost();
          }
          else{
            gameManager.opp.ActiveQLost();
          }
        }
        else
        {
              gameManager.random.question[gameManager.random.numRandom[countQuestions]].SetActive(false);
              gameManager.opp.lastChance = true;
              countQuestions++;
              ActiveQuestions();
        }
        
    }

     public void AnswerReset(Button button)
     { 
        Color32 colorReset = new Color(255f, 255f, 255f);
        button.image.color = colorReset;
        gameManager.bloqueo.DesBloqueoPantalla();
        new WaitForSeconds(1);
     }

}
