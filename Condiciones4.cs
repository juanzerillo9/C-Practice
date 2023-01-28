using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Condiciones4 : MonoBehaviour
{
    void Start()
    {
        // Bucle For de toa la vida
        for (int i = 0; i <= 10; i++)
        {
            Debug.Log(i);
            if (i > 1 && i < 6)
            {
                Debug.Log("Nivel so Bajo");
            }
        }
    }

}
