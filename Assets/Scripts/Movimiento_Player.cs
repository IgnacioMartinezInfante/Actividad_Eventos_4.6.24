using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento_Player : MonoBehaviour
{
    public float velocidad = 5f; 

    void Update()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal");

        Vector3 movimiento = new Vector3(movimientoHorizontal, 0f, 0f) * velocidad * Time.deltaTime;

        transform.Translate(movimiento);
    }
}
