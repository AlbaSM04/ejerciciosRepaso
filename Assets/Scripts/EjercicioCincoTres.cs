using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioCincoTres : MonoBehaviour
{
    [SerializeField] int numeroEntero;
    void Start()
    {
        if (numeroEntero > 0 && numeroEntero < 9)
        {
            Debug.Log("El numero esta comprendido entre el cero y el nueve");
        }
        else
        {
            Debug.Log("El numero no esta comprendido entre el cero y el nueve");
        }
    }
}
