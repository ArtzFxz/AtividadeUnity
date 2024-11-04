using UnityEngine;

public class Exercicio04 : MonoBehaviour
{
    [SerializeField] bool pocaoCura;
    void Start()
    {
        print((pocaoCura == true) ? "Usando Poção de Vida" : "Poção indisponível");
    }

    void Update()
    {
        
    }
}
