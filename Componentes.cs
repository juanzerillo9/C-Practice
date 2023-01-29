using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Componentes : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {

        // Ver si esta activo
        // Debug.Log(gameObject.activeSelf);

        // Desactivar componente
        //gameObject.SetActive(false);

        // Agregar componente
        //gameObject.AddComponent<Rigidbody>();

        // Nombre del objeto
        Debug.Log(gameObject.name);

        // Modificar componente transform
        gameObject.transform.position = new Vector3(5, 0, 5);
        // o
        transform.position = new Vector3(5, 0, 5);

        // Ver la posicion
        Debug.Log(transform.position);

        // Modificar rotacion
        transform.rotation = Quaternion.Euler(45, 90, 0);

        // Cambiar escala
        transform.localScale = new Vector3(transform.localScale.x, 7, 7); // transform.localScale.x da el valor que tiene actualmente el eje x



    }


}
