using UnityEngine;

public class Exercicio05 : MonoBehaviour
{
    [SerializeField] int pontosMissao = 0;
    void Start()
    {
        if (pontosMissao > 50)
        {
            print("Miss�o Bem-sucedida!");
        }
        else
        {
            print("Miss�o incompleta");
        }
    }

    void Update()
    {
        
    }
}
