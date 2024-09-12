using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicioDosCinco : MonoBehaviour
{
    int vidasPlayer1 = 1; 
    int vidasPlayer2 = 2; 
    int vidasPlayer3 = 3; 
    int vidasPlayer4 = 4;

    void Start()
    {
        vidasPlayer2 = vidasPlayer3;
        vidasPlayer3 = vidasPlayer1;
        vidasPlayer1 = vidasPlayer4;
        vidasPlayer4 = vidasPlayer2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
