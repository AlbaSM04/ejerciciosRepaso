using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioSieteSeis : MonoBehaviour
{
    [SerializeField] int numero1;
    int numero2;
    
    void Start()
    {
        numero2 = numero1;
        for (int i = (numero1 * -1); i <= numero1; numero1 --)
        {
            Debug.Log("El numero es " + numero1 + " for");
        }

        int numeroNegativo = numero2 * -1;
        while (numero2 >= numeroNegativo)
        {
            Debug.Log("El numero es " + numero2 + " while");
            numero2--;
        }

        
    }

    
    void Update()
    {
        
    }
}
