using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Condiciones4 : MonoBehaviour
{
    int[] array = { 2, 3, 4, 6, 8, 0 };

    float[] arrayFloat = new float[5];

    string[] arrayString = { "a", "b", "c" };

    void Start()
    {
        arrayFloat[0] = 2.5f;

        // Bucle For de toa la vida
        for (int i = 0; i <= array.Length; i++)
        {
            Debug.Log(array[i]);

            if (i > 1 && i < 6)
            {
                Debug.Log("Nivel so Bajo");
            }
        }
    }

}
