using System;
using UnityEngine;

public class DesafioR : MonoBehaviour
{
    void Start()
    {
        string input = "Polegato";

        int count = 0;

        foreach (char c in input)
        {
            if ("bcdfghjklmnpqrstvwxyzBCDFGHJKLMNPQRSTVWXYZ".Contains(c))
            {
                count++;
            }
        }
        print("N�mero de consoantes em 'Polegato': " + count);
    }

    void Update()
    {
        
    }
}
