using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicioCuatroCuatro : MonoBehaviour
{
    
    void Start()
    {
        float convertidoMS = Convertir (5);
        
        Debug.Log("Ahora tienes " + convertidoMS + " m/s");
    }

    
    float Convertir (float kilometrosHora)
    {
        Debug.Log("Ahora tienes " + kilometrosHora + " Km/h");
        float convertidoMS = (kilometrosHora * 100) / 3600;
        return convertidoMS;
    }
}
