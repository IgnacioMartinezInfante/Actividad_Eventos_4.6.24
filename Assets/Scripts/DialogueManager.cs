using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI dialogueText;

    private void OnEnable()
    {
        NPC.onNPCInteract += MostrarDialogo;
    }

    private void OnDisable()
    {
        NPC.onNPCInteract -= MostrarDialogo;
    }

    private void MostrarDialogo()
    {
        dialogueText.text = "¡Hola, aventurero! ¿Cómo puedo ayudarte hoy?";
    }
}
