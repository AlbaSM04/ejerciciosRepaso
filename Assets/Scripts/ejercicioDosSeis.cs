using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicioDosSeis : MonoBehaviour
{
    int puntuacionUno = 1, puntuacionDos = 2, puntuacionTres = 3;
    int media;

    void Start()
    {
        Debug.Log("Puntuacion uno: " + puntuacionUno);
        Debug.Log("Puntuacion dos: " + puntuacionDos);
        Debug.Log("Puntuacion tres: " + puntuacionTres);

        media = (puntuacionUno + puntuacionDos + puntuacionTres) / 3;
        Debug.Log("La media de las tres puntuaciones es " + media);
    }


    
    void Update()
    {
        
    }
}
