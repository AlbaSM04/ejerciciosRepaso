using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioCincoDiez : MonoBehaviour
{
    [SerializeField] float temperatura;
    void Start()
    {
        if (temperatura <= 10) 
        {
            Debug.Log("Hace frio");
        }
        else if (10 < temperatura && temperatura <= 20) 
        {
            Debug.Log("Esta nublado");
        }
        else if (20 < temperatura && temperatura <= 30) 
        {
            Debug.Log("Hace un dia caluroso");
        }
        else if (temperatura > 30) 
        {
            Debug.Log("Hace un dia tropical");
        }
    }

    
    void Update()
    {
        
    }
}
