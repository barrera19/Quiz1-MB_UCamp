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
    public GameObject pantallafinal;
    public Bloqueo bloqueo;
    

    public void Start()
    {
        pantallaInicial.SetActive(true);
        panelPreguntas.SetActive(false);
        pantallafinal.SetActive(false);
        bloqueo.DesBloqueoPantalla();
        random.inicio();
        active.ActiveQuestions();
    
    }
     
     
}
