using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class ActiveQuestion : MonoBehaviour
{

  public GameManager gameManager;
    public int countQuestions = 0;
    public RandomSelect random;
    public int points = 0;

    public FinalGame fin;
    public LastQuestion lastQ;
    public TextMeshProUGUI puntaje;
    
 
    public void ActiveQuestions()
    {        

        if(countQuestions != 0)
        {
          random.question[random.numRandom[countQuestions]].SetActive(false);
          countQuestions++;
          if(countQuestions == random.question.Length - 1)
          {
            print("entre al final");
            random.question[random.numRandom[countQuestions-1]].SetActive(false);
            lastQ.LastQ();
          }
          else
          {
            random.question[random.numRandom[countQuestions]].SetActive(true);
          }
          
        }
        else
        {
            random.question[random.numRandom[0]].SetActive(false);
            countQuestions++; 
            random.question[random.numRandom[countQuestions]].SetActive(true);
        }
    }

    public void CorrectAnswer(Button button)
    {
        StartCoroutine(AnswerColorCorrect(button));
        puntaje.text = points.ToString();
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
