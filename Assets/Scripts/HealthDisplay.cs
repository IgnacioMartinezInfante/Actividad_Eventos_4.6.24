using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    public Text textoSalud;
    public PlayerHealth playerHealth;


    private void OnEnable()
    {
        PlayerHealth.playerHealthEvent += ActualizarMostrarSalud;
    }

    private void OnDisable()
    {
        PlayerHealth.playerHealthEvent -= ActualizarMostrarSalud;

    }
    private void ActualizarMostrarSalud()
    {
        if (playerHealth != null)
        {
            textoSalud.text = "Salud: " + playerHealth.salud.ToString();
        }
    }
}
