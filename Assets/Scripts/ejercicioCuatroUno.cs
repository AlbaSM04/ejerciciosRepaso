using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicioCuatroUno : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float areaCirculo = AreaCirculo(5);
        Debug.Log("El area del circulo es: " + areaCirculo);
       
        float areaTriangulo = AreaTriangulo(4, 5);
        Debug.Log("El area del triangulo es: " + areaTriangulo);
        
        float areaCuadrado = AreaCuadrado(5);
        Debug.Log("El area del cuadrado es: " + areaCuadrado);
    }

    float AreaCirculo (float radio)
    {
        float areaCirculo;
        areaCirculo = (radio * radio) * 3.14f;
        return areaCirculo;        
    }

    float AreaTriangulo (float altura, float baseTriangulo)
    {
        float areaTriangulo;
        areaTriangulo = (baseTriangulo * altura) / 2;
        return areaTriangulo;
    }

    float AreaCuadrado (float lado) 
    {
        float areaCuadrado;
        areaCuadrado = lado * lado;
        return areaCuadrado;
    }
}
