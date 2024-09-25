using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EjercicioSieteNueve : MonoBehaviour
{
    [SerializeField] int numero1;
    int numero2 = 0;

    void Start()
    {
        while (numero2 < numero1)
        {
            numero2++;
            if (numero2 % 3 == 0)
            {
                Debug.Log("Multiplos de 3: " + numero2);
            }
        }  
    }

    
    void Update()
    {
        
    }
}
