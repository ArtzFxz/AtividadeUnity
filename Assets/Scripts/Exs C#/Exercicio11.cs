using UnityEngine;

public class Exercicio11 : MonoBehaviour
{
    [SerializeField] int NPC = 0;
    void Start()
    {
        switch (NPC)
        {
            case 0:
                print("Bem vindo ao jogo!!");
                break;

            case 1:
                print("Voc� completou a fase!");
                break;

            case 2:
                print("Voc� conseguiu uma moeda!");
                break;

            case 3:
                print("Voc� derrotou todos os inimigos!");
                break;

            case 4:
                print("Muito obrigado por jogar!");
                break;
        }
    }

    void Update()
    {
        
    }
}
