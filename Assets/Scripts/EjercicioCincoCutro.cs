using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioCincoCutro : MonoBehaviour
{
    [SerializeField] float dividendo, divisor;
    void Start()
    {
       if (divisor == 0)
       {
            Debug.Log("No se puede hacer la operción");
       }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
