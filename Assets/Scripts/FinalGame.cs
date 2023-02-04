using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 
public class FinalGame : MonoBehaviour
{
    public ActiveQuestion questions;
    public GameObject pantallaFinal;
    public GameObject reinicio;
    public GameObject welcome;
    public GameObject panelPreguntas;
    public RandomSelect random;
    public GameManager gameManager;
    
    public void FinalScreen()
    { 
       panelPreguntas.SetActive(false);
       pantallaFinal.SetActive(true);
    }

    public void restart()
    {
        questions.countQuestions = 0;
        questions.points = 0;
        random.numRandom = new List<int>();
        gameManager.Start();
        pantallaFinal.SetActive(false);
        welcome.SetActive(true);
        
        
    }
}
