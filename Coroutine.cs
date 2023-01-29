using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Coroutine : MonoBehaviour
{

    public int variable = 1;
    void Start()
    {
        //StartCoroutine("Coroutine2", 2);

        Invoke("Disparar", 3);

        Destroy(gameObject, 10);
    }

    // Update is called once per frame
    void Update()
    { 
        
    }

    IEnumerator Coroutine2(float time)
    {
        // La corutina sirve para detener la ejecucion x un tiempo
        Debug.Log("Hola! Soy una corutina!!!");

        yield return new WaitForSeconds(time);

        Debug.Log("Bunos Dias!");

        yield return new WaitForSeconds(time);

        Debug.Log("Hasta Luego!");

        yield return new WaitForSeconds(time);

        Debug.Log("Mi nombre es JZ9");

        StartCoroutine("Coroutine2", 2);
    }

    void Disparar()
    {
        // Metodo Invoke
        Debug.Log("Disparo");
    }
}
