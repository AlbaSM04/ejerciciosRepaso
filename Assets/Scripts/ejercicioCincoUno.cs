using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicioCincoUno : MonoBehaviour
{
    [SerializeField] int vidasJugadorUno, vidasJugadorDos;
    void Start()
    {
        if (vidasJugadorUno == vidasJugadorDos)
        {
            Debug.Log("Estais empate");
        }
        else if (vidasJugadorUno < vidasJugadorDos)
        {
            Debug.Log("Jugador dos gana");
        }        
        else if (vidasJugadorUno > vidasJugadorDos)
        {
            Debug.Log("Jugador uno gana");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
