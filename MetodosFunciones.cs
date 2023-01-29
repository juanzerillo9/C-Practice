using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetodosFunciones : MonoBehaviour
{
    // Public hace que se pueda editar desde Unity.
    public float a = 1, b = 2;


    // Start is called before the first frame update
    private void Start()
    {
        Sumar(4, 6);
        Respuesta("Hola");
        string RespuestaMetodo;

        RespuestaMetodo = Respuesta2("Adios");

        Debug.Log(RespuestaMetodo);
    }

    private void Sumar(float a, float b)
    {
        float suma = a + b;
        Debug.Log(suma);
    }

    // Update is called once per frame
    private void Update()
    {
        
    }

    private void FixedUpdate()
    {
        // Mejor para el tema de fisicas, va despuesd el update
    }

    private void LateUpdate()
    {
        //Posterior al update y fixedUpdate
    }

    private void OnDisable()
    {
        // Se ejecuta cuando un objeto especifico se desactiva
        Debug.Log("OnDisable");
    }
    private void OnEnable()
    {
        Debug.Log("OnEnable");
        // Se ejecuta cuando un objeto especifico se activa
    }


    public void Respuesta(string palabra)
    {
        if (palabra == "Hola")
        {
            Debug.Log("Hola, que tal");
        }
        else if (palabra == "Adios")
        {
            Debug.Log("Hasta Luego");
        }
        else
        {
            Debug.Log("No entender");
        }
    }
    public string Respuesta2(string palabra)
    {
        if (palabra == "Hola")
        {
            return "Hola, que tal";
        }
        else if (palabra == "Adios")
        {
           return "Hasta Luego";
        }
        else
        {
            return "No entender";
        }
    }


}
