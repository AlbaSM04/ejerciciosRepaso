using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioDosCuatro : MonoBehaviour
{
    int vidas = 0;

    void Start()
    {
        vidas += 77;
        Debug.Log("Vidas incrementa 77: " + vidas);

        vidas -= 3; 
        Debug.Log("Vidas decrece 3: " + vidas);

        vidas = vidas * 4;
        Debug.Log("Vidas cuadruplica su valor: " + vidas);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
