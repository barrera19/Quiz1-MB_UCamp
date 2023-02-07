using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public RandomSelect random;
    public ActiveQuestion active;
    public FinalGame final;
    public LastQuestion lastQ;
    public GameObject pantallaInicial;
    public GameObject panelPreguntas;
    public GameObject pantallaFinal;
    public Bloqueo bloqueo;
    public Opportunities opp;
    public QuestionCounter questionCounter;
    

    public void Start()
    {
        pantallaInicial.SetActive(true);
        panelPreguntas.SetActive(false);
        pantallaFinal.SetActive(false);
        bloqueo.DesBloqueoPantalla();
        random.inicio();
        active.ActiveQuestions();
    }

    public void ExitGame()
    {
        Application.Quit();
    }
     
}
