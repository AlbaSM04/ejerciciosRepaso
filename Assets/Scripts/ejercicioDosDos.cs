using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicioDosDos : MonoBehaviour
{
    int vidas = 5;
    float exp = 15.5f;
    char carac = 'f';

    
    void Start()
    {
        Debug.Log("Vidas: " + vidas + ". Experiencia: " + exp);
        
        float resultadoSuma = vidas + exp;
        float resultadoResta = exp - vidas;

        Debug.Log ("Resultados resta: " + resultadoResta + ". Resultado suma: " + resultadoSuma);
        
    }


    void Update()
    {
        
    }
}
