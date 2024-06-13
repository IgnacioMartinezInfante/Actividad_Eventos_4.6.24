using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateManager : MonoBehaviour
{
    public delegate void GameStateEvent();
    public static event GameStateEvent onGameStartEvent;
    public static event GameStateEvent onGamePauseEvent;

    public void IniciarJuego()
    {
        onGameStartEvent?.Invoke();
        Debug.Log("Juego Iniciado");
    }

    public void PausarJuego()
    {
        onGamePauseEvent?.Invoke();
        Debug.Log("Juego Pausado");
    }
}
