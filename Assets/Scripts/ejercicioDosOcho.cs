using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicioDosOcho : MonoBehaviour
{
    float puntosIniciales = 120f, vidaActual;

    void Start()
    {
        Debug.Log ("Puntos iniciales: " +  puntosIniciales);

        vidaActual = puntosIniciales - (puntosIniciales * 3f / 100f);
        Debug.Log ("Ha pasado el primer turno, has perdido el 3% de los puntos iniciales," + 
            " Ahora tienes: " + vidaActual + "puuntos");
        
        vidaActual = puntosIniciales - (puntosIniciales * 6f / 100f);
        Debug.Log ("Ha pasado el segundo turno, has perdido el 6% de los puntos iniciales," + 
            " Ahora tienes: " + vidaActual + "puntos");        
        
        vidaActual = puntosIniciales - (puntosIniciales * 9f / 100f);
        Debug.Log ("Ha pasado el tercer turno, has perdido el 9% de los puntos iniciales," + 
            " Ahora tienes: " + vidaActual + "puntos");
        
        vidaActual = puntosIniciales - (puntosIniciales * 12f / 100f);
        Debug.Log ("Ha pasado el cuarto turno, has perdido el 12% de los puntos iniciales," + 
            " Ahora tienes: " + vidaActual + "puntos");
        
        vidaActual = puntosIniciales - (puntosIniciales * 15f / 100f);
        Debug.Log("Ha pasado el quinto turno, has perdido el 15% de los puntos iniciales," +
            " Ahora tienes: " + vidaActual + "puntos");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
