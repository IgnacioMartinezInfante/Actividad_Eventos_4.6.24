using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI dialogueText;

    private void OnEnable()
    {
        // Suscribirse al evento de interacción con el NPC
        NPC.onNPCInteract += MostrarDialogo;
    }

    private void OnDisable()
    {
        // Desuscribirse del evento de interacción con el NP
        NPC.onNPCInteract -= MostrarDialogo;
    }

    private void MostrarDialogo()
    {
        // Mostrar el diálogo en la UI
        dialogueText.text = "¡Hola, aventurero! ¿Cómo puedo ayudarte hoy?";
    }
}
