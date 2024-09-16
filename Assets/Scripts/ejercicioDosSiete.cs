using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioDosSiete : MonoBehaviour
{
    int oroSegundo = 7, despuesCuatroHoras;

    void Start()
    {
        despuesCuatroHoras = oroSegundo * 14400;
        Debug.Log("Oro conseguido despues de 4 horas: " + despuesCuatroHoras);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
