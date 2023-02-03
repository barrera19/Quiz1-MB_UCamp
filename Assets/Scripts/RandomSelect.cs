using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSelect : MonoBehaviour
{
    [SerializeField] int numQuestions;
    public int count = 0;
    public List<int> numRandom;
    public bool stop = false;
    public GameObject[] questions;


    void Start()
    {
         while (!stop)
         {  
            int temp = Random.Range(0, numQuestions - 1);
             if (!numRandom.Contains(temp))
             {
                 numRandom.Add(temp);
                 count++;      
             }
              if (count  == numQuestions - 1)
            {
                stop = true;
                //break;
            }  
                         
         }

        ActiveQuestion();

        }

        

    public void ActiveQuestion()
    {
        questions[numRandom[0]].SetActive(true);
    }

}
