using UnityEngine;

public class Geral : MonoBehaviour
{
    /*
        Operadores relacionais 
        == ( igual )
        != ( diferente )
        >  ( maior que )
        <  ( menor que )
        <= ( menor igual )
        >= ( maior igual )

     */

    //[SerializeField] int vidaHeroi = 100;
    //[SerializeField] int vidaVilao = 300;
    //string resultado;

    [SerializeField] int estadoVilao = 1;

    void Start()
    {
        //print(vidaVilao == vidaHeroi);//false
        //print(vidaHeroi <= vidaVilao);//true
        //print(vidaVilao != vidaHeroi);//true

        //Operador ternário
        // condição ? valor a ser atribuido caso verdadeiro : caso falso
        //resultado = vidaHeroi < vidaVilao ? "Vida Heroi Menor" : "Vida Heroi Maior";

        //print(resultado);

        //estrutura condicional
        //if (vidaHeroi < vidaVilao)
        //{
        //    resultado = "Vida Heroi Menor";
        //    print(resultado);
        //}
        //else if (vidaHeroi == vidaVilao)
        //{
        //    resultado = "Vida Heroi igual a Vida Vilão";
        //    print(resultado);
        //}
        //else
        //{
        //    resultado = "Vida Heroi Menor";
        //    print(resultado);

        //estado 01: vilão ataca
        //estado 02: vilão defende
        //estado 03: vilão toma dano

        switch (estadoVilao)
        {
            case 1:
                print("Vilão atacando");
                if (true)
                {
                    print("Danoo");
                }
                break;

            case 2:
                print("Vilão defendendo");
                break;

            case 3:
                print("Vilão tomando um coro");
                break;

            default:
                print("Valor não identificado");
                break;
        }
    }

    void Update()
    {
      
    }
}


