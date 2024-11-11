using UnityEngine;

public class Exs08R : MonoBehaviour
{
    string nome = "Polegato";
    string programa;
    void Start()
    {
        for (int i = nome.Length; i > 0; i--)
        {
            programa += nome[i - 1];
        }
        print(programa);
    }

    void Update()
    {
        
    }
}
