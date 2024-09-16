using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioDosCinco : MonoBehaviour
{
    int vidasPlayer1 = 1; 
    int vidasPlayer2 = 2; 
    int vidasPlayer3 = 3; 
    int vidasPlayer4 = 4;
    int vidasIniciales2;

    void Start()
    {
        Debug.Log("Vidas iniciales Player 1: " +  vidasPlayer1);
        Debug.Log("Vidas iniciales Player 2: " +  vidasPlayer2);
        Debug.Log("Vidas iniciales Player 3: " +  vidasPlayer3);
        Debug.Log("Vidas iniciales Player 4: " +  vidasPlayer4);

        vidasIniciales2 = vidasPlayer2;
        vidasPlayer2 = vidasPlayer3;
        Debug.Log("Nuevas vidas Player 2: " + vidasPlayer2);
        
         vidasPlayer3 = vidasPlayer1;
        Debug.Log("Nuevas vidas Player 3: " + vidasPlayer3);
        
        vidasPlayer1 = vidasPlayer4;
        Debug.Log("Nuevas vidas Player 1: " + vidasPlayer1);

        vidasPlayer4 = vidasIniciales2;
        Debug.Log("Nuevas vidas Player 4: " + vidasPlayer4);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
