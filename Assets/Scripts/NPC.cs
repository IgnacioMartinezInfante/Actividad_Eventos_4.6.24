using UnityEngine;
using UnityEngine.Events;

public class NPC : MonoBehaviour
{
    // Define un evento para cuando el jugador interact�e con el NPC
    public delegate void NPCInteractEvent();
    public static event NPCInteractEvent onNPCInteract;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Jugador entr� en la zona del NPC");
            Interactuar();
        }
    }

    private void Interactuar()
    {
        // Dispara el evento de interacci�n
        onNPCInteract?.Invoke();
    }
}
