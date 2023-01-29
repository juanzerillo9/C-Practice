using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guardar : MonoBehaviour
{
    int Numero;
    string stringnombre;

    void Start()
    {
        PlayerPrefs.SetInt("numeroInt", 21);
        PlayerPrefs.SetString("nombre", "Hola");

        Numero = PlayerPrefs.GetInt("numeroInt");
        stringnombre = PlayerPrefs.GetString("nombre");
        // Borrar informacion en especifico
        //PlayerPrefs.DeleteKey("numeroInt");
        //PlayerPrefs.DeleteAll();

    }

    void Update()
    {
        Debug.Log(Numero);
        Debug.Log(stringnombre);
    }
}


