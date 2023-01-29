using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Herencias : MonoBehaviour
{
    void Start()
    {
        // crear un nuevo usuario de la clase
        Enemy enemy1 = new Enemy();

        enemy1.vida = 5;

        enemy1.Ataq();

        EnemigoVolador enemigoVolador = new EnemigoVolador();

        enemigoVolador.ataqueVolador();

        enemigoVolador.Ataq();
    }

}

class Enemy
{
    public int vida;
    public string name;
    public float ataque, speed;
    
    public void Ataq()
    {
        Debug.Log("MeleeAttack");
    }
}

class EnemigoVolador : Enemy // Los ods puntitos significa que heredan sus propiedades
{   
    public void ataqueVolador()
    {
        Debug.Log("Ataque volador");
    }
}
