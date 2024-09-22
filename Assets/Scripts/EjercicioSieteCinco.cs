using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioSieteCinco : MonoBehaviour
{
    [SerializeField] float numero;
    float numeroResultante = 1;
    void Start()
    {
        while (numero >= numeroResultante )
        {
            Debug.Log ("El numero es " + numeroResultante + " con while");
            numeroResultante++;
        }

        for (numeroResultante = 1; numeroResultante <= numero; numeroResultante++) 
        {
            Debug.Log("El numero es " + numeroResultante + " con for");
        }
    }

    
    void Update()
    {
        
    }
}
