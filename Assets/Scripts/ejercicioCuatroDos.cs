using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioCuatroDos : MonoBehaviour
{
    
    void Start()
    {
        string nombreCompleto = ConstruirNombre("Alba", "Sim�n", "M�ndez", 20); 
        Debug.Log(nombreCompleto);
    }

    string ConstruirNombre (string nombre, string apellido1, string apellido2, int edad)
    {
        string nombreCompleto = "El jugador se llama " + nombre + " " + apellido1 + " " + apellido2 + " y tiene " + edad + " a�os";
        return nombreCompleto;
    }
}
