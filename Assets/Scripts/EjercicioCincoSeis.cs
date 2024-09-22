using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioCincoSeis : MonoBehaviour
{
    [SerializeField] int niveles;
    void Start()
    {
        if (niveles%10 == 0)
        {
            Debug.Log("Tu pokémon ha aprendido un nuevo ataque");
        }
        else 
        {
            Debug.Log("Sigue subiendo de nivel para que tu pokémon aprenda un ataque nuevo");
        }
    }

    
    void Update()
    {
        
    }
}
