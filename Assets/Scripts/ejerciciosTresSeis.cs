using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosTresSeis : MonoBehaviour
{
    [SerializeField] float velocidadKmH;
    float velocidadMS;

    void Start()
    {
        Debug.Log ("Tu velocidad en Km/h es: " +  velocidadKmH);

        velocidadMS = (velocidadKmH * 1000)/(60*60);

        Debug.Log ("Tu velocidad en m/s es: " + velocidadMS);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
