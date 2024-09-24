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

        for (float i = 1; i <= numero; i++) 
        {
           Debug.Log("El numero es " + i + " con for");
        }
    }

    
    void Update()
    {
        
    }
}
