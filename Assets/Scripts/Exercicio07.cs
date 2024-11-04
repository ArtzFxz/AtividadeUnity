using UnityEngine;

public class Exercicio07 : MonoBehaviour
{
    [SerializeField]int nLados = 20;
    void Start()
    {
       int resultado = Random.Range(1, nLados);
        print(resultado);
    }

    void Update()
    {
        
    }
}
