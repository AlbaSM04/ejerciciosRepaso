using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioSieteUno : MonoBehaviour
{
    int numero = 1;
    void Start()
    {
        while (numero <= 100)
        {
            Debug.Log ("El numero es " + numero);
            numero++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
