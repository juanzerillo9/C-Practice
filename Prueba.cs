using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prueba : MonoBehaviour
{

    int Nivel = 1;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Me ejecuto al principio");
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Nivel >= 150)
        {
            Debug.Log("Nono un rey total, pasa kpo ya sos nivel "+ Nivel);
            Nivel++;
        }
        else
        {
            Debug.Log("Todavia sos nivel bajo, tu nivel actual es: "+Nivel);
            Nivel++;
        }
    }
}
