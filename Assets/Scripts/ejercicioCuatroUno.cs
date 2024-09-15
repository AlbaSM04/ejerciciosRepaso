using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicioCuatroUno : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AreaCirculo(5);
        AreaTriangulo(4, 5);
        AreaCuadrado(5);
    }

    void AreaCirculo (float radio)
    {
        float areaCirculo;
        areaCirculo = (radio * radio) * 3.14f;

        Debug.Log ("El area del circulo es: " + areaCirculo);
    }

    void AreaTriangulo (float altura, float baseTriangulo)
    {
        float areaTriangulo;
        areaTriangulo = (baseTriangulo * altura) / 2;

        Debug.Log ("El area del triangulo es: " + areaTriangulo);
    }

    void AreaCuadrado (float lado) 
    {
        float areaCuadrado;
        areaCuadrado = lado * lado;

        Debug.Log("El area del cuadrado es: " + areaCuadrado);
    }
}
