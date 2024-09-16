using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosTresCuatro : MonoBehaviour
{
    [SerializeField] int exp;
    int nivel;
    void Start()
    {
        Debug.Log ("Tu esperiencia es: " + exp);

        nivel = 32 + (9 * exp/5);

        Debug.Log("Tu nivel es: " + nivel);
    }

    
    void Update()
    {
        
    }
}
