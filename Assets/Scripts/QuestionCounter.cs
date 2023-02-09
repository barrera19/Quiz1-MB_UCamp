using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QuestionCounter : MonoBehaviour
{
    public GameManager gameManager;
    public TextMeshProUGUI actualQuestion;
    public TextMeshProUGUI totalQuestions;

    public void counterQuestion()
    {
        actualQuestion.text = (gameManager.active.countQuestions+1).ToString();
        totalQuestions.text = (gameManager.random.numQuestions-1).ToString();
    }
    
}
