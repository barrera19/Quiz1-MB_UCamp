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
    

    public void Start()
    {
        random.inicio();
        active.ActiveQuestions();
    }
     
     
}
