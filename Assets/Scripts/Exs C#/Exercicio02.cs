using UnityEngine;

public class Exercicio02 : MonoBehaviour
{
    [SerializeField] bool powerUp;//true
    // ! --> Inverte o valor
    
    void Start()
    {
        //if (powerUp == true)
        //{
        //    print("Power-up Coletado!");
        //}
        //else
        //{
        //    print("Nenhum Power-up encontrado");
        //}

        print((powerUp == true) ? "Power-up Coletado!" : "Nenhum Power-up encontrado");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
