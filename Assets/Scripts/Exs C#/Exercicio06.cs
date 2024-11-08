using UnityEngine;

public class Exercicio06 : MonoBehaviour
{
    [SerializeField] bool Mago;
    void Start()
    {
        if (Mago == true)
        {
            print("Mago escolhido");
        }
        else
        {
            print("Guerreiro escolhido");
        }
    }

    void Update()
    {
        
    }
}
