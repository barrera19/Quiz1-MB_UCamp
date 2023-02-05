using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkipQuestion : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject botonOmitir;

    public void omitirPregunta()
    {
        gameManager.active.ActiveQuestions();
    } 
}
