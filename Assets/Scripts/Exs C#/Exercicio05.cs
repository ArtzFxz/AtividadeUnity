using UnityEngine;

public class Exercicio05 : MonoBehaviour
{
    [SerializeField] int pontosMissao = 0;
    void Start()
    {
        if (pontosMissao > 50)
        {
            print("Missão Bem-sucedida!");
        }
        else
        {
            print("Missão incompleta");
        }
    }

    void Update()
    {
        
    }
}
