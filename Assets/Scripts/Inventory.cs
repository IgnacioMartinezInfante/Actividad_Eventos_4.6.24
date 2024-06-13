using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private List<Collectible> items = new List<Collectible>();

    private void OnEnable()
    {
        Collectible.onCollectedEvent += AddItem;
    }

    private void OnDisable()
    {
        Collectible.onCollectedEvent -= AddItem;
    }

    public void AddItem(Collectible item)
    {
        items.Add(item);
        Debug.Log("Objeto recolectado: " + item.name);
    }
}
