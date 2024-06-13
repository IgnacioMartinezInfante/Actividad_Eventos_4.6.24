using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateManager : MonoBehaviour
{
    // Define delegados y eventos para manejar cambios en el estado del juego
    public delegate void GameStateEvent();
    public static event GameStateEvent onGameStartEvent;
    public static event GameStateEvent onGamePauseEvent;

    // Métodos para iniciar y pausar el juego
    public void IniciarJuego()
    {
        // Dispara el evento de iniciar jueg
        onGameStartEvent?.Invoke();
        Debug.Log("Juego Iniciado");
    }

    public void PausarJuego()
    {
        // Dispara el evento de pausar juego
        onGamePauseEvent?.Invoke();
        Debug.Log("Juego Pausado");
    }
}
