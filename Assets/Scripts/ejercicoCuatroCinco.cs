using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicoCuatroCinco : MonoBehaviour
{
    [SerializeField] string moneda;
    void Start()
    {
        float areaCirculo = AreaCirculo(5);
        Debug.Log("El area del circulo es: " + areaCirculo + ". Por lo que contamos que tienes " + areaCirculo + " monedas.");
        if (moneda == "EUROS")
        {
            float resultado = Convertir(areaCirculo);
            Debug.Log("Al convertir de euros a dolares tienes " + resultado + " dolares");
        }

        if (moneda == "DOLARES")
        {
            float resultado = Convertir(areaCirculo);
            Debug.Log("Al convertir de dolares a euros tienes " + resultado + " euros");
        }

        float areaTriangulo = AreaTriangulo(4, 5);
        Debug.Log("El area del triangulo es: " + areaTriangulo + ". Por lo que contamos que tienes " + areaTriangulo + " monedas.");
        if (moneda == "EUROS")
        {
            float resultado = Convertir(areaTriangulo);
            Debug.Log("Al convertir de euros a dolares tienes " + resultado + " dolares");
        }

        if (moneda == "DOLARES")
        {
            float resultado = Convertir(areaTriangulo);
            Debug.Log("Al convertir de dolares a euros tienes " + resultado + " euros");
        }

        float areaCuadrado = AreaCuadrado(5);
        Debug.Log("El area del cuadrado es: " + areaCuadrado + ". Por lo que contamos que tienes " + areaCuadrado + " monedas.");
        if (moneda == "EUROS")
        {
            float resultado = Convertir(areaCuadrado);
            Debug.Log("Al convertir de euros a dolares tienes " + resultado + " dolares");
        }

        if (moneda == "DOLARES")
        {
            float resultado = Convertir(areaCuadrado);
            Debug.Log("Al convertir de dolares a euros tienes " + resultado + " euros");
        }
    }

    float AreaCirculo(float radio)
    {
        float areaCirculo;
        areaCirculo = (radio * radio) * 3.14f;
        return areaCirculo;
    }

    float AreaTriangulo(float altura, float baseTriangulo)
    {
        float areaTriangulo;
        areaTriangulo = (baseTriangulo * altura) / 2;
        return areaTriangulo;
    }

    float AreaCuadrado(float lado)
    {
        float areaCuadrado;
        areaCuadrado = lado * lado;
        return areaCuadrado;
    }
    float Convertir(float cantidad)
    {
        float resultado = 0f;

        if (moneda == "EUROS")
        {
            Debug.Log("Tienes " + cantidad + " euros");
            resultado = cantidad * 1.11f;
        }

        if (moneda == "DOLARES")
        {
            Debug.Log("Tienes " + cantidad + " dolares");
            resultado = cantidad / 1.11f;
        }
        return resultado;

    }
}
