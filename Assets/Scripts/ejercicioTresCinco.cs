using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicioTresCinco : MonoBehaviour
{
    [SerializeField] float radio;
    float area, perimetro;

    void Start()
    {
        Debug.Log("Tu radio es: " + radio);

        area = 3.14f * (radio * radio);
        perimetro = 2 * 3.14f * radio;

        Debug.Log ("El area es: " +  area);
        Debug.Log ("El perimetro es: " +  perimetro);

    }

    
    void Update()
    {
        
    }
}
