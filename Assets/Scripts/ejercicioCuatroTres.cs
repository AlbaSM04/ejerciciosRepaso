using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicioCuatroTres : MonoBehaviour
{
    [SerializeField] string moneda;

    void Start()
    {       
        if (moneda == "EUROS")
        {
            float resultado = Convertir(5);
            Debug.Log("Al convertir de euros a dolares tienes " + resultado + " dolares");
        }

        if (moneda == "DOLARES")
        {
            float resultado = Convertir(5);
            Debug.Log("Al convertir de dolares a euros tienes " + resultado + " euros");
        }
    }

    float Convertir (float cantidad)
    {
        float resultado = 0;

        if (moneda == "EUROS")
        {
            Debug.Log("Tienes " + cantidad + " euros");
            resultado = cantidad * 1.11f;
        }

        if (moneda == "DOLARES")
        {
            Debug.Log("Tienes " + cantidad + " dolares");
            resultado = cantidad / 1.11f;
        }
        return resultado;

    }

    
}
