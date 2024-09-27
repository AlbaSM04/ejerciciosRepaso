using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioSieteDoce : MonoBehaviour
{
    void Start()
    {
        int resultados = SumarTodosLosNumeros(6, 4);
        Debug.Log(resultados);
    }

    int SumarTodosLosNumeros(int numeroMayor, int numeroMenor)
    {
        int sumaNumeros = 0;
        while (numeroMenor <= numeroMayor)
        {
            sumaNumeros += numeroMenor;
            numeroMenor++;
        }
        return sumaNumeros;
    }
}
