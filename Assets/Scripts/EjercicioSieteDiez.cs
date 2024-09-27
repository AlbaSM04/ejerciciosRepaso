using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioSieteDiez : MonoBehaviour
{
    [SerializeField] int numeroMenor, numeroMayor;
    void Start()
    {
        while (numeroMenor <= numeroMayor)
        {
            numeroMayor--;
            Debug.Log("Los numero entre medias son " + numeroMayor);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
