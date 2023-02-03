using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSelect : MonoBehaviour
{
    [SerializeField] int numQuestions;
    public int count = 0;
    public int countQuestions = 0;
    public List<int> numRandom;
    public bool stop = false;
    public GameObject[] questions;
    public int points = 0;


    void Start()
    {
         while (!stop)
         {  
            int temp = Random.Range(0, numQuestions - 1);

             if (!numRandom.Contains(temp))
             {
                 numRandom.Add(temp);
                 count++;
                 print("Count: " + count);    
                 print("Numero Preguntas: " + numQuestions);

             }  
                  
                if (count  == numQuestions -1)
                {
                    stop = true;
                } 
                        
         }

        ActiveQuestion();

        }
    public void ActiveQuestion()
    {
        if(countQuestions != 0)
        {
          questions[numRandom[countQuestions]].SetActive(false);
          countQuestions++;  
          questions[numRandom[countQuestions]].SetActive(true);
    
        }
        else
        {
            questions[numRandom[0]].SetActive(false);
            questions[numRandom[countQuestions]].SetActive(true);
            countQuestions++;
        }
    
    }

    public void CorrectAnswer()
    {
        points = points + 100;
        ActiveQuestion();

    }


    public void IncorrectAnwser()
    {
        ActiveQuestion();
    }
}
