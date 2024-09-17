using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioCincoDos : MonoBehaviour
{
    [SerializeField] int numeroUno, numeroDos;
    void Start()
    {
        if (numeroUno < 3 && numeroDos < 3)
        {
            Debug.Log("Ambos numeros son menores que 3");
        }
        else
        {
            Debug.Log("Unos de los dos numeros es mayor a 3");
        }
    }

    
    void Update()
    {
        
    }
}
