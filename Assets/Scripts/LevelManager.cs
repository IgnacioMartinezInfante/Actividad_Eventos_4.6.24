using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    // Define delegados y eventos para manejar cambios de nivel
    public delegate void LevelChangeEvent();
    public static event LevelChangeEvent onLevelChangeEvent;

    private bool enPrimeraEscena = true;
    private string primeraEscena = "Ejercicio4";
    private string segundaEscena = "Ejercicio4Nivel2";
    private string nombreEscenaActual; // Variable para almacenar el nombre de la escena actual


    private void Update()
    {
        // Detectar si se presiona la tecla 'Q'
        if (Input.GetKeyDown(KeyCode.Q))
        {
            CambiarNivel();
        }
    }

    // Método para cambiar de nivel
    public void CambiarNivel()
    {
        // Dispara el evento de cambio de nivel
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
