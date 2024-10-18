using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // For:
        for (int i = 0; i < 5; i++)
        {
            Debug.Log("Valor de i: " + i);
        }

        for (int j = 5; j > 0; j--)
        {
            Debug.Log("Valor de j: " + j);
        }

        for (int k = 0; k <= 10; k += 2)
        {
            Debug.Log("Valor de k: " + k);
        }

        // While:
        int cont = 0;
        while (cont < 5)
        {
            Debug.Log("Valor de cont: " +  cont);
            cont++;
        }

        int cont2 = 0;
        while (cont2 <= 10)
        {
             if (cont2 % 2 == 0)
            {
                Debug.Log("Número: " + cont2);
            }
            cont2++;
        }

        // Do While:
        int newcount = 5;
        do
        {
            Debug.Log("Valor de New Count: " + newcount);
            newcount--;
        } while (newcount > 0);
    }
}
