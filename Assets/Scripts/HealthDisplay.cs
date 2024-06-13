using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    // Referencia al componente Text de la UI
    public Text textoSalud;
    public PlayerHealth playerHealth;


    private void OnEnable()
    {
        // Suscribirse al evento AlCambiarSalud
        PlayerHealth.playerHealthEvent += ActualizarMostrarSalud;
    }

    private void OnDisable()
    {
        // Desuscribirse del evento AlCambiarSalud para evitar errores
        PlayerHealth.playerHealthEvent -= ActualizarMostrarSalud;

    }
        // Método para actualizar la UI de salud
    private void ActualizarMostrarSalud()
    {
        if (playerHealth != null)
        {
            textoSalud.text = "Salud: " + playerHealth.salud.ToString();
        }
    }
}
