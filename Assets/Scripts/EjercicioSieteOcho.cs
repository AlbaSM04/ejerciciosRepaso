using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EjercicioSieteOcho : MonoBehaviour
{
    [SerializeField] int numero1, numero2; 
    int numero3;
    void Start()
    {
        Debug.Log("El numero 1 es " + numero1);
        Debug.Log("El numero 2 es " + numero2);
        numero3 = numero2;

        while (numero1 < numero2)
        {
            numero2--;
            if (numero2 % 2 == 0)
            {
                Debug.Log("Los numero pares entre medias son " + numero2);
            }
            
        }

        while (numero3 < numero1)
        {
            numero1--;
            if (numero1 % 2 == 0)
            {
                Debug.Log("Los numero pares entre medias son " + numero1);
            }
        }
    }

    
    void Update()
    {
        
    }
}
