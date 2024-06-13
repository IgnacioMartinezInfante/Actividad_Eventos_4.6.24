using UnityEngine;
using TMPro; // Necesario para usar TextMeshPro

public class LevelDisplay : MonoBehaviour
{
    // Referencia al elemento de texto de la UI (TextMeshPro)
    public TextMeshProUGUI levelText;

    private void OnEnable()
    {
        // Suscribirse al evento de cambio de nivel
        LevelManager.onLevelChangeEvent += MostrarCambioNivel;
    }

    private void OnDisable()
    {
        // Desuscribirse del evento de cambio de nivel
        LevelManager.onLevelChangeEvent -= MostrarCambioNivel;
    }

    // Método para mostrar el cambio de nivel en la UI
    private void MostrarCambioNivel()
    {
        levelText.text = "Nivel cambiado!";
    }
}