using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioCincoOcho : MonoBehaviour
{
    [SerializeField] int horas, minutos, segundos;
    void Start()
    {
        if (minutos > 60 || segundos > 60)
        {
            Debug.Log("La hora no es valida");
        }
        else 
        {
            Debug.Log ("La hora es: " + horas + ":" + minutos + ":" + segundos);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
