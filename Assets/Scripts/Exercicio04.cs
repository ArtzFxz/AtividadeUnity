using UnityEngine;

public class Exercicio04 : MonoBehaviour
{
    [SerializeField] bool pocaoCura;
    void Start()
    {
        print((pocaoCura == true) ? "Usando Po��o de Vida" : "Po��o indispon�vel");
    }

    void Update()
    {
        
    }
}
