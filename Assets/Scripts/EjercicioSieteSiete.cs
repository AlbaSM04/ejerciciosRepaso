using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioSieteSiete : MonoBehaviour
{
    [SerializeField] int numero1, numero2;
    int numero3;
    
    void Start()
    {
        Debug.Log("El numero 1 es " + numero1);
        Debug.Log("El numero 2 es " + numero2);
        numero3 = numero2;
        while (numero1 < numero2 )
        {
            numero2--;
            Debug.Log("Los numero entre medias son " + numero2);
        }

        while (numero3 < numero1)
        {
            numero1--;
            Debug.Log("Los numero entre medias son " + numero1);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
