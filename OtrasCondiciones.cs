using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtrasCondiciones : MonoBehaviour
{

    int condicion = 1;

    void Start()
    {
        // Sentencia Switch, igual que toa la vida
        switch (condicion)
        {
            case 1:
                Debug.Log("Ataque Basico");
                break;

            case 2:
                Debug.Log("Ataque Fuerte");
                break;
            case 3:
                Debug.Log("Ataque Magico");
                break;
            default:
                Debug.Log("No hacer nada");
                break;
        }
    }
}

