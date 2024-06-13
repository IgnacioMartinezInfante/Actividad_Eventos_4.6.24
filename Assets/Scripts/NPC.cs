using UnityEngine;
using UnityEngine.Events;

public class NPC : MonoBehaviour
{
    // Define un evento para cuando el jugador interactúe con el NPC
    public delegate void NPCInteractEvent();
    public static event NPCInteractEvent onNPCInteract;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Jugador entró en la zona del NPC");
            Interactuar();
        }
    }

    private void Interactuar()
    {
        // Dispara el evento de interacción
        onNPCInteract?.Invoke();
    }
}
