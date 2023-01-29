using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practica : MonoBehaviour
{
    string[] Jugadores = new string[4];

    int[] nivel = { 1, 1, 1, 1 };

    public string Nombre = "nadie";

    void Start()
    {
        Jugadores[0] = "Manuel";
        Jugadores[0] = "Juan";
        Jugadores[0] = "Juli";
        Jugadores[0] = "Nico";
        LosMuchachos(Nombre);
    }

    void Update()
    {
        
    }



    private void OnDisable()
    {
        LosMuchachos(Nombre);
    }

    private void OnEnable()
    {
        LosMuchachos(Nombre);
    }

    private void LosMuchachos(string nombre)
    {

        for (int i = 0; i < Jugadores.Length; i++)
        {
            if (Jugadores[i] == nombre)
            {
                nivel[i] += 1;
                Debug.Log("Ahora " + nombre + " es nivel " + nivel[i]);
            }
        }
    }
}
    