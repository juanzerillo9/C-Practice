using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Listas : MonoBehaviour
{

    List<int> numerosEnteros = new List<int>();
    List<float> numerosNoEnteros = new List<float>();
    List<string> Nombres = new List<string>();

    string frase = "Me gustan los videojuegos";

    int[] numeros = { 1, 3, 7, 4, 7, 9 };


    // Start is called before the first frame update
    void Start()
    {
        // Agregar a una lista
        numerosEnteros.Add(1); 
        numerosEnteros.Add(2);
        numerosEnteros.Add(3);

        numerosNoEnteros.Add(2.4f);

        Nombres.Add("Juan");

        // Contar cantidad
        Debug.Log(numerosEnteros.Count);

        // Agregar en un lugar especifico
        numerosEnteros.Insert(0, 5); // Insertar en la posicion 0, el valor 5

        // Borrar de una lista
        numerosEnteros.Remove(3);

        // Borrar TAL indice
        numerosEnteros.RemoveAt(0);


        // ForEach para recorrer arrays, strings, listas
        foreach (int Num in numerosEnteros)
        {
            Debug.Log(Num);
        }

        foreach (char caracter in frase)
        {
            Debug.Log(caracter);
        }

        foreach (int nums in numeros)
        {
            Debug.Log(nums);
        }
    }

}
