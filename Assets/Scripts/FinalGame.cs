using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 
using UnityEngine.UI;
public class FinalGame : MonoBehaviour
{
    public ActiveQuestion questions;
    public GameObject pantallaFinal;
    public GameObject reinicio;
    public GameObject welcome;
    public GameObject panelPreguntas;
    public RandomSelect random;
    public GameManager gameManager;
    public TextMeshProUGUI puntajeFinal;
    
    public void FinalScreen()
    { 
       puntajeFinal.text = questions.puntaje.text;
       panelPreguntas.SetActive(false);
       pantallaFinal.SetActive(true);
    }

    public void restart()
    {
        questions.countQuestions = 0;
        questions.points = 0;
        random.numRandom = new List<int>();
        questions.puntaje.text = " 0";
        gameManager.Start();
        pantallaFinal.SetActive(false);
        welcome.SetActive(true);
        
        
    }
}
