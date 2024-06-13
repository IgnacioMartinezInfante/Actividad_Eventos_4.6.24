using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerHealth : MonoBehaviour
{
    public delegate void PlayerHealthEvent();
    public static PlayerHealthEvent playerHealthEvent;

    // Define una variable de salud
    public int salud = 10;
    public int cantidad = 15;

    private void Update()
    {
        // Detectar si se presiona la tecla 'q'
        if (Input.GetKeyDown(KeyCode.Q))
        {
            AumentarSalud(15); // Llama al m�todo para reducir la salud en 10
        }
    }

    // M�todo para cambiar la salud
    public void CambiarSalud(int cantidadsalud)
    {
        salud += cantidadsalud;

        playerHealthEvent?.Invoke();
    }

    // M�todo para reducir la salud (puede ser privado si no necesitas llamarlo desde otros scripts)
    private void AumentarSalud(int cantidad)
    {
        CambiarSalud(cantidad);
    }
}

