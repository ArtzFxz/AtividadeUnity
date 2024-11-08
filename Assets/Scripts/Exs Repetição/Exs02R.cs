using UnityEngine;

public class Exs02R : MonoBehaviour
{
    void Start()
    {
        int dano = 2;

        for (int hit = 0; hit < 5; hit++)
        {
            dano += 2;
            print(dano);
        }
    }

    void Update()
    {
        
    }
}
