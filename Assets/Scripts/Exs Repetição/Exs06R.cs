using UnityEngine;

public class Exs06R : MonoBehaviour
{
    void Start()
    {
        for (int i = 0; i <= 10000; i++)
        {
            if (i % 3 == 0)
            {
                print("fizz");
            }
            else if (i % 5 == 0)
            {
                print("buzz");
            }
            else if (i % 3 == 0 && i % 5 == 0)
            {
                print("fizz-buzz");
            }
            else
            {
                print(i);
            }
        }
    }

    void Update()
    {
        
    }
}
