using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioSieteSeis : MonoBehaviour
{
    [SerializeField] int numero;
    
    void Start()
    {
        int numeroNegativo = numero * -1;
        while (numero >= numeroNegativo)
        {

            Debug.Log("El numero es " + numero + " while");
            numero--;
        }

        for (int numeroNegativoFor = numero * -1; numero >= numeroNegativoFor; numero-- )
        {
            Debug.Log("El numero es " + numero + " for");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
