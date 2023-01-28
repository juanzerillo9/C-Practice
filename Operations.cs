using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operations : MonoBehaviour
{
    float a = 10, b = 2;  // we can assign the same type in the same line.

    float resultado = 0f;


    void Start()
    {
        // Operaciones
        // Sumar
        resultado = a + b;

        // Restar 
        resultado = a - b;

        // Multiplicar
        resultado = a * b;

        // Dividir
        resultado = a / b;

        // Modulo (Resto de la division)
        resultado = a % b;

        // Mas Uno
        a++;
        b++;

        a += b; // Es igual a:
        a = a + b; // Lo mismo sucede en la resta



        Debug.Log("El resultado es: "+resultado);

        resultado = a * b;

        Debug.Log("El nuevo resultado es : " + resultado);
    }
}
