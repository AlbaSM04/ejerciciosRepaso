using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioTresTres : MonoBehaviour
{

    [SerializeField] int numero;
    int numeroDoble, numeroTriple;

    void Start()
    {
        Debug.Log("Numero inicial: " +  numero);
        
        numeroDoble = numero * 2;
        numeroTriple = numero * 3;

        Debug.Log("Numero inicial por dos: " + numeroDoble);
        Debug.Log("Numero inicial por tres: " + numeroTriple);
    }

    
    void Update()
    {
        
    }
}
