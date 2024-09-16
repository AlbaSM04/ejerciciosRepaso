using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioUno : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("¡Hola mundo!");
        Debug.Log("Este es el primer videojuego de Alba");
        Debug.Log("Estoy aprendiendo C#");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Ha pasado un frame");
        /* El motivo por el cual este mensaje se repite todo el rato
         * es debido a que esta situadi en el Void Update y al estar 
         * alli se repite cada frame*/
    }
}
