using UnityEngine;
using TMPro; 

public class LevelDisplay : MonoBehaviour
{
    public TextMeshProUGUI levelText;

    private void OnEnable()
    {
        LevelManager.onLevelChangeEvent += MostrarCambioNivel;
    }

    private void OnDisable()
    {
        LevelManager.onLevelChangeEvent -= MostrarCambioNivel;
    }

    private void MostrarCambioNivel()
    {
        levelText.text = "Nivel cambiado!";
    }
}