using UnityEngine;

public class Exercicio09 : MonoBehaviour
{
    [SerializeField] int timeA = 3;
    [SerializeField] int timeB = 3;
    void Start()
    {
            if (timeA == timeB && timeA >= 3)
            {
                print("Um EMPATE Emocionante!");
            }
            else if (timeA == timeB)
            {
                print("Empate :/ ");
            }
            else if (timeA > timeB)
            {
                print("Vitória do Time A!!");
            }
            else
            {
                print("Vitória do Time B!!");
            }
        }

    void Update()
    {
        
    }
}
