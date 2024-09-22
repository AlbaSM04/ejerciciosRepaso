using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioCincoNueve : MonoBehaviour
{
    [SerializeField] int tipo;
    void Start()
    {
        if (tipo == 1)
        {
            Debug.Log("Es un enemigo de tipo uno, hace un daño de 350 y una vida de 650");
        }
        else if (tipo == 2)
        {
            Debug.Log("Es un enemigo de tipo dos, hace un daño de 300 y una vida de 550");
        }
        else if (tipo == 3)
        {
            Debug.Log("Es un enemigo de tipo tres, hace un daño de 300 y una vida de 500");
        }
        else if (tipo == 4)
        {
            Debug.Log("Es un enemigo de tipo cuatro, hace un daño de 310 y una vida de 460");
        }
        else if (tipo == 5)
        {
            Debug.Log("Es un enemigo de tipo cinco, hace un daño de 280 y una vida de 490");
        }
        else if (tipo == 6)
        {
            Debug.Log("Es un enemigo de tipo cinco, hace un daño de 360 y una vida de 520");
        }
        else
        {
            Debug.Log("No se genera ningun tipo de enemigo");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
