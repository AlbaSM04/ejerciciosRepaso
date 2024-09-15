using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicioTresSiete : MonoBehaviour
{
    [SerializeField] float baseTriangulo, altura;
    float area;

    void Start()
    {
        Debug.Log("La base: " + baseTriangulo + ". Su altura es: " + altura);

        area = (baseTriangulo * altura) / 2;

        Debug.Log ("El area es: " + area);
    }

    
    void Update()
    {
        
    }
}
