using System;
using UnityEngine;

public class Desafio2R : MonoBehaviour
{
    [SerializeField] int dia = 9;
    [SerializeField] int mes = 7;
    [SerializeField] int ano = 2007;
    [SerializeField] int diaAtual = DateTime.Now.Day;
    [SerializeField] int mesAtual = DateTime.Now.Month;
    [SerializeField] int anoAtual = DateTime.Now.Year;

    void Start()
    {
        int quantosAnos = anoAtual - ano;

        if (mesAtual < mes || (mesAtual == mes && diaAtual < dia)) { quantosAnos--; };

        int quantosMeses = (mesAtual - mes + 12) % 12;
        int quantosDias = (diaAtual - dia + 30) % 30;


        print($"Anos: {quantosAnos}");
        print($"Meses: {quantosMeses}");
        print($"Dias: {quantosDias}");

    }

    void Update()
    {

    }
}
