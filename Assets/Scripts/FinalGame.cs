using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class FinalGame : MonoBehaviour
{ 
    public GameManager gameManager;
    public TextMeshProUGUI puntajeFinal;
    
    public void FinalScreen()
    { 
       gameManager.active.puntaje.text = gameManager.active.points.ToString();
       puntajeFinal.text = gameManager.active.puntaje.text;
       gameManager.panelPreguntas.SetActive(false);
       gameManager.pantallaFinal.SetActive(true);
    }

    public void restart()
    {
        gameManager.active.countQuestions = 0;
        gameManager.active.points = 0;
        gameManager.random.count = 0;
        gameManager.random.numRandom = new List<int>();
        gameManager.active.puntaje.text = " 0";
        gameManager.Start();
        gameManager.pantallaFinal.SetActive(false);
        gameManager.pantallaInicial.SetActive(true);
        
        
    }
}
