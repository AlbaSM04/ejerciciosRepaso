using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EjercicioSieteTrece : MonoBehaviour
{
    [SerializeField] int numeroConsulta;
    int numeroDivision;
    void Start()
    {
        bool resultado = primo(numeroConsulta);
        Debug.Log(resultado);
    }

    
    bool primo (int numeroConsulta)
    {
        if (numeroConsulta <= 1)
        {
            return false;
        }

        
        for (int i = 2; i < numeroConsulta; i++)
        {
            if (numeroConsulta % i == 0)
            {
                return false; 
            }
        }

        return true; 
    }
}
