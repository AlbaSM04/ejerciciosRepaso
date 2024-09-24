using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioSieteSeis : MonoBehaviour
{
    [SerializeField] int numero;
    
    void Start()
    {
        for (int i = numero * -1; i <= numero; i--)
        {
            Debug.Log("El numero es " + numero + " for");
        }

        int numeroNegativo = numero * -1;
        while (numero >= numeroNegativo)
        {

            Debug.Log("El numero es " + numero + " while");
            numero--;
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
