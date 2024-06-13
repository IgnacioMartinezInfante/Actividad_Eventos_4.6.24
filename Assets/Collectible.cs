using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    // Define un delegado y un evento est�tico para cuando el objeto es recolectado
    public delegate void CollectibleEvent(Collectible item);
    public static event CollectibleEvent onCollectedEvent;

    // M�todo para recolectar el objeto
    public void Recolectar()
    {
        // Dispara el evento de recolecci�n
        onCollectedEvent?.Invoke(this);

        // Destruir el objeto despu�s de ser recolectado
        Destroy(gameObject);
    }

    // Detectar colisi�n con el jugador
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Recolectar();
        }
    }
}
