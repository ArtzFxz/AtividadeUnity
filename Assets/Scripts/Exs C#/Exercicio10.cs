using UnityEngine;

public class Exercicio10 : MonoBehaviour
{
    [SerializeField] int itens = 0;
    void Start()
    {
        switch (itens)
        {
            case 0:
                print("Moedas coletadas!");
                break;

            case 1:
                print("Poções coletadas!");
                break;

            case 2:
                print("Power ups coletados!");
                break;
            case 3:

                print("Espada coletada!");
                break;

            default:
                print("Você não coletou nenhum item!");
                break;
        }
    }

    void Update()
    {
        
    }
}
