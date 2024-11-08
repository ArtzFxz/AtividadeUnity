using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class LaçoDeRepetição : MonoBehaviour
{
    //For -> É utilizado quando se sabe a qtd. de repetições

    //While ou doWhile -> É utilizado quando não se sabe a qtd. de repetições

    //Foreach -> Quando tem uma lista que para cada elemento que quer fazer uma operação.

    //Array -> É uma lista 

    //int x = 0;
    //int y = 10;

    List<int> nums = new List<int>();

    void Start()
    {
        //----------------------------------------------------------------
        //for (Inicializador; condição; incremento)
        //for(int i = 0; i <= 10; i++)
        //{
        //    //if(i == 5)
        //    //{
        //    //    break;
        //    //}

        //    //if(i == 6)
        //    //{
        //    //    continue;
        //    //}
        //    //print(i);

        //}

        //----------------------------------------------------------------

        //WHILE
        //while (x <= 10)
        //{
        //    print(x);
        //    x++;
        //}

        //do
        //{
        //    print(y);
        //    y--;
        //}
        //while (y >= 0);

        //----------------------------------------------------------------

        int[] num = { 10, 20, 30, 40, 50, 60, 70, 80 };

        //print(num[3]);

        //num[0]++;

        //print(num[0]);

        //string[] nomes;
        //nomes = new string[5];
        //nomes[0] = "Tadola";

        //print(nomes[1]);

        //----------------------------------------------------------------

        //for (Inicializador; condição; incremento)
        //for (int i = 0; i <= 8; i++)
        //{
        //    print(num[i]);
        //}

        //foreach (var item in num)
        //{
        //    print(item);
        //}

        //----------------------------------------------------------------

        nums.Add(1); // indice 0
        nums.Add(2); // indice 1
        nums.Add(3); // indice 2
        nums.Add(4);
        nums.Add(4);
        nums.Add(5);
        nums.Add(6);
        nums.Add(7);
        nums.Add(8); // indice 8

        //Remove o primeiro valor '4' encontrado na lista (indice 3)
        //nums.Remove(4);

        ////Ordena os elementos da lista em ordem crescente
        //nums.Sort();

        //nums.Reverse();

        print(nums.IndexOf(5));
    }

    void Update()
    {
        
    }
}
