using UnityEngine;

public class Exs03R : MonoBehaviour
{
    [SerializeField] int moedas = 0;
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            moedas += 3;
            print(moedas);
        }
    }

    void Update()
    {
        
    }
}
