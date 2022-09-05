using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscena : MonoBehaviour
{
    public void CambiarEscenaClick(string sceneName)
    {
        Debug.Log("Saliendo del juego");
        StartCoroutine(retreosoEscena(sceneName));
        
    }


    public void SalirJuego()
    {
        Debug.Log("Saliendo del juego");
        Application.Quit();
    }

    IEnumerator retreosoEscena(string sceneName)
    {
        yield return new WaitForSecondsRealtime(1f);
        SceneManager.LoadScene(sceneName);
    }
}
