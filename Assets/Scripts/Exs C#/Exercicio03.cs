using UnityEngine;

public class Exercicio03 : MonoBehaviour
{
    /*
     && (E/ AND)
     || (OU / OR)
     ! (N�O / NOT)
     */

    [SerializeField] bool playerVivo;//true
    [SerializeField] bool powerUp;//true
    double vidaPlayer = 100;
    
    void Start()
    {
        if (playerVivo == false && powerUp == true)
        {
            vidaPlayer = vidaPlayer * 0.5;
            print("Ainda n�o, vida atual " + vidaPlayer);
        }
        else
        {
            print("Game Over");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
