using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioSieteTres : MonoBehaviour
{
    int numero = 100;
    void Start()
    {
        while (numero > 0)
        {
            Debug.Log("El numero es " + numero);
            numero--;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
