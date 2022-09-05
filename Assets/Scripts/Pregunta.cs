using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class Pregunta : MonoBehaviour
{
    public string enunciado;
    public Respuesta[] respuestas;

    public int respuestaCorrecta;
}
