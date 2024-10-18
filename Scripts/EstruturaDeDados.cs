using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstruturaDeDados : MonoBehaviour
{
    void Start()
    {
        // Arrays:
        int[] numeros = { 1, 2, 3, 4, 5 };
        Debug.Log(numeros[numeros.Length - 1]);

        // Modificando elementos do array:
        numeros[2] = 10;
        Debug.Log(numeros[2]);

        // Percorrendo arrays:
        for (int i = 0; i < numeros.Length; i++)
        {
            Debug.Log(numeros[i]);
        }

        Debug.Log("--------------");

        //Listas:
        List<string> nomes = new List<string> {"Nilson", "Mariana", "Flávia", "Josué"};
   
        // Manipulação de elementos:
        nomes.Add("Ana");
        nomes.Insert(0, "Lucas");
        nomes.Remove("Ana");
     
        foreach (string nome in nomes)
        {
            Debug.Log(nome);
        }
    }
}
