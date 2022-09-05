using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelComplementario : MonoBehaviour
{
    public GameObject panelComplementario;

    public Game gane;

    public void continuar()
    {
        panelComplementario.SetActive(false);
        gane.setPregunta();
    }

    public void desplegar()
    {
        panelComplementario.SetActive(true);
    }
}
