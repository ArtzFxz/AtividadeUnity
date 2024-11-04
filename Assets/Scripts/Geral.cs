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

        //Operador tern�rio
        // condi��o ? valor a ser atribuido caso verdadeiro : caso falso
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
        //    resultado = "Vida Heroi igual a Vida Vil�o";
        //    print(resultado);
        //}
        //else
        //{
        //    resultado = "Vida Heroi Menor";
        //    print(resultado);

        //estado 01: vil�o ataca
        //estado 02: vil�o defende
        //estado 03: vil�o toma dano

        switch (estadoVilao)
        {
            case 1:
                print("Vil�o atacando");
                if (true)
                {
                    print("Danoo");
                }
                break;

            case 2:
                print("Vil�o defendendo");
                break;

            case 3:
                print("Vil�o tomando um coro");
                break;

            default:
                print("Valor n�o identificado");
                break;
        }
    }

    void Update()
    {
      
    }
}


