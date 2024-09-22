using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioCincoCinco : MonoBehaviour
{
    [SerializeField] int nivelJugador;
    void Start()
    {
        if(nivelJugador%2 == 0)
        {
            Debug.Log("Tu nivel es par");
        }
        else if (nivelJugador%2 != 0)
        {
            Debug.Log("Tu nivel es inpar");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
