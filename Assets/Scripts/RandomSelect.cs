using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSelect : MonoBehaviour
{
    public int numQuestions;
    public List<int> numRandom = new List<int>();
    public int count = 0;
    bool stop = false;
    public GameObject[] question;


    public void inicio()
    {
        while(!stop)
         {  
            if(numRandom.Count == numQuestions -1)
             {
                break;
             }
            else
            {
            int temp = Random.Range(0, numQuestions );

             if (!numRandom.Contains(temp))
             {
                 numRandom.Add(temp);
                 count++;
             }    
             
             }
             
         }

        }
}
