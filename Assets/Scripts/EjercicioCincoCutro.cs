using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioCincoCutro : MonoBehaviour
{
    [SerializeField] float dividendo, divisor;
    void Start()
    {
       if (divisor == 0)
       {
            Debug.Log("No se puede hacer la operci�n");
       }
       else
       {
            Debug.Log("Se puede hacer la divisi�n");
            float resultadoDivision = dividendo / divisor;
            Debug.Log ("El resultado es " +  resultadoDivision);
       }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
