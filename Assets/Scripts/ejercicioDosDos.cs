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
        Debug.Log(vidas + " " + exp);
        
        float resultadoSuma = vidas + exp;
        float resultadoResta = exp - vidas;

        Debug.Log (resultadoResta + " " + resultadoSuma);
        
    }


    void Update()
    {
        
    }
}
