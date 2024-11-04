using System;
using UnityEngine;

public class Exercicio01 : MonoBehaviour
{

    [SerializeField] int vidaHeroi = 100;
    void Start()
    { 
        if (vidaHeroi > 0)
        {
            print("Personagem Vivo");
        }
        else
        {
            print("Game Over");
        }

        //condição ? valor a ser chamado caso verdadeiro : caso falso
        resultado = (vidaHeroi > 0) ? "Personagem Vivo!" : "Game Over! ;-;";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
