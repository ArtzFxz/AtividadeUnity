using UnityEngine;

public class Exs07R : MonoBehaviour
{
    int[] nums = { 23, 71, 88, 41, 11, 65};
    void Start()
    {
        int maior = 0;
        foreach (int num in nums)
        {
            if (num > maior) { maior = num; }
        }
        print(maior);
    }
        

    void Update()
    {
        
    }
}
