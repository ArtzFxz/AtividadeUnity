using UnityEngine;

public class Exs04R : MonoBehaviour
{
    [SerializeField] int pontos = 0;
    void Start()
    {
        for (int i = 0; i < 7; i++)
        {
            pontos += 10;
            print(pontos);
        }
    }

    void Update()
    {
        
    }
}
