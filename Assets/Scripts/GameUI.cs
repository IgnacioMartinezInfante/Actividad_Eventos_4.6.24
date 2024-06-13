using UnityEngine;
using TMPro; 

public class GameUI : MonoBehaviour
{
    public TextMeshProUGUI pausaText;
    public TextMeshProUGUI reanudadoText;

    private void OnEnable()
    {
        GameStateManager.onGameStartEvent += MostrarReanudado;
        GameStateManager.onGamePauseEvent += MostrarPausa;
    }

    private void OnDisable()
    {
        GameStateManager.onGameStartEvent -= MostrarReanudado;
        GameStateManager.onGamePauseEvent -= MostrarPausa;
    }

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
