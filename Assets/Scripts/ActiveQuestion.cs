using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class ActiveQuestion : MonoBehaviour
{

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

    public void CorrectAnswer()
    {
        points = points + 100;
        puntaje.text = points.ToString();
        ActiveQuestions();
        
    }

    public void IncorrectAnwser()
    {
        ActiveQuestions();
        
    }

}
