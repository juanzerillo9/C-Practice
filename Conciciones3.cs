using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conciciones3 : MonoBehaviour
{
    bool condicion = true;
    int i = 1;
    void Start()
    {
        //Do while
        do
        {
            Debug.Log("Hola");
        } while (true);


        // While 
        while (i <= 5 && condicion)
        {
            Debug.Log("Hola");
            i++;
        }
        
    }

}
