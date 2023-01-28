using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Condiciones : MonoBehaviour
{
    // If Statement, Control de flujo.
    //Operadores relacionales
    // < Menor que      <= Menor igual que
    // > Mayor que      >= Mayor igual que
    // == Igual que
    // != Distinto de 

    // Operadores Logicos
    // &&       AND
    // ||       OR
    // !        NOT 


    int vida = 3;

    int edad = 23;

    int Level = 20;

    bool Llave = true;



    void Start()
    {
        if (vida > 0)
        {
            Debug.Log("Estoy vivo y tengo " + vida + " vidas");
        }
        if (vida <= 0)
        {
            Debug.Log("Estoy meurto, ya no tengo mas vidas");
        }


        if (edad >= 18)
        {
            Debug.Log("Eres mayor de edad");
        }
        else if(edad < 18 && edad > 10)
        {
            Debug.Log("Eres menor de edad, eres un adolescente"); 
        }
        else
        {
            Debug.Log("Eres un niñ@");
        }



        if (Level >= 20 || Llave)
        {
            Debug.Log("Podemos entrar a la Dungeon");
        }
    }


}
