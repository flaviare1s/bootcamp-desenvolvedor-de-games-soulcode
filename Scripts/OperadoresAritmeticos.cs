using System;
using System.Collections.Generic;
using UnityEngine;

public class OperadoresAritmeticos : MonoBehaviour
{
    int a = 10;
    int b = 3;
    float c = 3.4f;

    void Start()
    {
        Debug.Log("Soma (a + b): " + (a + b));
        Debug.Log("Subtração (a - b): " + (a - b));
        Debug.Log("Multiplicação (a * b): " + (a * b));
        Debug.Log("Divisão (a / b): " + (a / b));
        Debug.Log("Resto da Divisão (a % b): " + (a % b));

        // Conversão implícita:
        float novo_b = b;
        Debug.Log(novo_b);


        // Comversão explícita:
        int novo_c = (int)c;
        Debug.Log(novo_c);

        // Conversão de string:
        string numeroString = "100";
        int numeroInt = Convert.ToInt32(numeroString);
        int numeroInt2 = int.Parse(numeroString);
        Debug.Log(numeroString);
        Debug.Log(numeroInt);
        Debug.Log(numeroInt2);
        Debug.Log("Tipo de dado: " + numeroString.GetType());

    }
}
