using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public delegate void LevelChangeEvent();
    public static event LevelChangeEvent onLevelChangeEvent;

    private bool enPrimeraEscena = true;
    private string primeraEscena = "Ejercicio4";
    private string segundaEscena = "Ejercicio4Nivel2";
    private string nombreEscenaActual; 


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            CambiarNivel();
        }
    }

    public void CambiarNivel()
    {
        onLevelChangeEvent?.Invoke();
        nombreEscenaActual = SceneManager.GetActiveScene().name;

        if (nombreEscenaActual == primeraEscena)
        {
            SceneManager.LoadScene(segundaEscena);
        }
        else
        {
            SceneManager.LoadScene(primeraEscena);
        }
    }
}
