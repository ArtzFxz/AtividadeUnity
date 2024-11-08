using UnityEngine;

public class Exs05R : MonoBehaviour
{
    [SerializeField] int pontos = 0;
    void Start()
    {
        for (int i = 0; i < 6; i++)
        {
            pontos += 5;
            print(pontos);
        }
    }

    void Update()
    {
        
    }
}
