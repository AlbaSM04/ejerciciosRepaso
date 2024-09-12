using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicioDosDos : MonoBehaviour
{
    int vidas = 5;
    float exp = 15.5f;
    char carac = 'f';

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(vidas + " " + exp);
        
        float resultadoSuma = vidas + exp;
        float resultadoResta = exp - vidas;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
