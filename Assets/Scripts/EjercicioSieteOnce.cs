using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioSieteOnce : MonoBehaviour
{
    int numeroMultiplicar = 0, resultadoMultiplicacion;
    [SerializeField] int numeroElegido;
    void Start()
    {
        Debug.Log("El numero que vamos a multiplicar es " + numeroElegido);

        while (numeroMultiplicar <= 10)
        {
            resultadoMultiplicacion = numeroElegido * numeroMultiplicar;
            Debug.Log("Vamos a multiplicar " + numeroMultiplicar + " por " + numeroElegido + " y el resultado es " + resultadoMultiplicacion);
            numeroMultiplicar++;
        }
    }


    void Update()
    {

    }
}
