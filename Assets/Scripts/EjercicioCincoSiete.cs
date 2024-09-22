using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioCincoSiete : MonoBehaviour
{
    [SerializeField] int velocidadUno, velocidadDos, velocidadTres;
    void Start()
    {
        if (velocidadUno > velocidadDos && velocidadUno > velocidadTres)
        {
            Debug.Log("El jugador uno es el mas rapido asi que empieza el");
        }
        else if (velocidadDos > velocidadUno && velocidadDos > velocidadTres)
        {
            Debug.Log("El jugador dos es el mas rapido asi que empieza el");
        }
        else if (velocidadTres > velocidadUno && velocidadTres > velocidadDos)
        {
            Debug.Log("El jugador tres es el mas rapido asi que empieza el");
        }
    }

    
    void Update()
    {
        
    }
}
