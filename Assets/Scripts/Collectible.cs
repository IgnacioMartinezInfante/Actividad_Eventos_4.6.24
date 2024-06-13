using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    // Define un delegado y un evento estático para cuando el objeto es recolectado
    public delegate void CollectibleEvent(Collectible item);
    public static event CollectibleEvent onCollectedEvent;

    // Método para recolectar el objeto
    public void Recolectar()
    {
        // Dispara el evento de recolección
        onCollectedEvent?.Invoke(this);

        // Destruir el objeto después de ser recolectado
        Destroy(gameObject);
    }

    // Detectar colisión con el jugador
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("colisiono");
            Recolectar();
        }
    }
}
