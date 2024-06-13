using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public delegate void CollectibleEvent(Collectible item);
    public static event CollectibleEvent onCollectedEvent;

    public void Recolectar()
    {
        onCollectedEvent?.Invoke(this);

        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("colisiono");
            Recolectar();
        }
    }
}
