using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI dialogueText;

    private void OnEnable()
    {
        // Suscribirse al evento de interacci�n con el NPC
        NPC.onNPCInteract += MostrarDialogo;
    }

    private void OnDisable()
    {
        // Desuscribirse del evento de interacci�n con el NP
        NPC.onNPCInteract -= MostrarDialogo;
    }

    private void MostrarDialogo()
    {
        // Mostrar el di�logo en la UI
        dialogueText.text = "�Hola, aventurero! �C�mo puedo ayudarte hoy?";
    }
}
