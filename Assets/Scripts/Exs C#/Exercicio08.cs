using UnityEngine;

public class Exercicio08 : MonoBehaviour
{
    [SerializeField] int hora;
    [SerializeField] int dia;
    [SerializeField] float segundos;

    void Start()
    {

    }

    void Update()
    {
        segundos += Time.deltaTime;
        if (segundos >= 10f)
        {
            hora++;
            segundos = 0;
            if (hora == 24)
            {
                hora = 0;
                dia++;
                print(dia);
            }
        }
    }
}
