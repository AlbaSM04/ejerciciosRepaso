using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicioDosTres : MonoBehaviour
{
    int vidas = 5;
    float exp = 15.4f;

    void Start()
    {
        float resultadoProducto = vidas * exp;
        float resultadoCociente = vidas / exp;
        float resultadoResto = vidas % exp;
        float resultadoDoble = vidas * 2;
        float resultadoTriple = 3 * exp;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
