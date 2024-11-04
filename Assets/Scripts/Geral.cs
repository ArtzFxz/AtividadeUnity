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

    [SerializeField] int vidaHeroi = 100;
    [SerializeField] int vidaVilao = 300;
    string resultado;

    void Start()
    {
        print(vidaVilao == vidaHeroi);//false
        print(vidaHeroi <= vidaVilao);//true
        print(vidaVilao != vidaHeroi);//true

        //Operador ternário
        // condição ? valor a ser atribuido caso verdadeiro : caso falso
        //resultado = vidaHeroi < vidaVilao ? "Vida Heroi Menor" : "Vida Heroi Maior";

        //print(resultado);

        //estrutura condicional
        if (vidaHeroi < vidaVilao)
        {
            resultado = "Vida Heroi Menor";
            print(resultado);
        }
        else if (vidaHeroi == vidaVilao)
        {
            resultado = "Vida Heroi igual a Vida Vilão";
            print(resultado);
        }
        else
        {
            resultado = "Vida Heroi Menor";
            print(resultado);
        }

    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
