using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioSieteDiez : MonoBehaviour
{
    [SerializeField] int numeroMenor, numeroMayor;
    void Start()
    {
        while (numeroMenor < numeroMayor)
        {
            numeroMayor--;
            Debug.Log("Los numero entre medias son " + numeroMayor);

            if (numeroMayor % 2 == 0)
            {
                Debug.Log("El numero es par");
            }
            else
            {
                Debug.Log("El numero es inpar");
            }

            if (numeroMayor < 0)
            {
                Debug.Log("El numero es negativo");
            }
            else
            {
                Debug.Log("El numero es positivo");
            }
        }  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
