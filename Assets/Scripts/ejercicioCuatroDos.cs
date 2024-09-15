using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicioCuatroDos : MonoBehaviour
{
    
    void Start()
    {
        ConstruirNombre("Alba", "Simón", "Méndez", 20);    
    }

    void ConstruirNombre (string nombre, string apellido1, string apellido2, int edad)
    {
        Debug.Log("El jugador se llama " + nombre + " " + apellido1 + " " + apellido2 + " y tiene " + edad + " años");
    }
}
