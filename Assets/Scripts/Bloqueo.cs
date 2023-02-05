using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloqueo : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject panelBloqueo;

    public void BloqueoPantalla()
    {
        panelBloqueo.SetActive(true);
    }

    public void DesBloqueoPantalla()
    {
        panelBloqueo.SetActive(false);
    }

    public IEnumerator BloqueoPreguntas(GameObject panel)
    {
        yield return new WaitForSeconds(0.5f);
        panel.SetActive(true);
    }




}
