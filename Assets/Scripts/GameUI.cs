using UnityEngine;
using TMPro; // Necesario para usar TextMeshPro

public class GameUI : MonoBehaviour
{
    // Referencias a los elementos de texto de la UI (TextMeshPro)
    public TextMeshProUGUI pausaText;
    public TextMeshProUGUI reanudadoText;

    private void OnEnable()
    {
        // Suscribirse a los eventos de estado del juego
        GameStateManager.onGameStartEvent += MostrarReanudado;
        GameStateManager.onGamePauseEvent += MostrarPausa;
    }

    private void OnDisable()
    {
        // Desuscribirse de los eventos de estado del juego
        GameStateManager.onGameStartEvent -= MostrarReanudado;
        GameStateManager.onGamePauseEvent -= MostrarPausa;
    }

    // Métodos para manejar los eventos y actualizar la UI
    private void MostrarPausa()
    {
        pausaText.gameObject.SetActive(true);
        reanudadoText.gameObject.SetActive(false);
    }

    private void MostrarReanudado()
    {
        pausaText.gameObject.SetActive(false);
        reanudadoText.gameObject.SetActive(true);
    }
}
