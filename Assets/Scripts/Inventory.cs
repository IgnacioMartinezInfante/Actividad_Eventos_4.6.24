using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    // Lista para almacenar los objetos recolectado
    private List<Collectible> items = new List<Collectible>();

    private void OnEnable()
    {
        // Suscribirse al evento onCollectedEvent
        Collectible.onCollectedEvent += AddItem;
    }

    private void OnDisable()
    {
        // Desuscribirse del evento onCollectedEvent para evitar errores
        Collectible.onCollectedEvent -= AddItem;
    }

    // Método para agregar un objeto al inventario
    public void AddItem(Collectible item)
    {
        items.Add(item);
        Debug.Log("Objeto recolectado: " + item.name);
    }
}
