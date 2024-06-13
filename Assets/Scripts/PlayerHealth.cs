using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerHealth : MonoBehaviour
{
    public delegate void PlayerHealthEvent();
    public static PlayerHealthEvent playerHealthEvent;

    public int salud = 10;
    public int cantidad = 15;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            AumentarSalud(15); 
        }
    }

    public void CambiarSalud(int cantidadsalud)
    {
        salud += cantidadsalud;

        playerHealthEvent?.Invoke();
    }

    private void AumentarSalud(int cantidad)
    {
        CambiarSalud(cantidad);
    }
}

