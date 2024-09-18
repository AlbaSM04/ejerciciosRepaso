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
        else if (numeroEntero == 0)
        {
            Debug.Log("El numero es cero");
        } 
        else if (numeroEntero == 9)
        {
            Debug.Log("El numero es nueve");
        }
        else
        {
            Debug.Log("El numero no esta comprendido entre el cero y el nueve");
        }
    }
}
