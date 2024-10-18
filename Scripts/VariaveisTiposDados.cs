using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariaveisTiposDados : MonoBehaviour
{
    // Tipo de dado inteiro
    int vidaPersonagem = 10;

    // Tipo de dado de ponto flutuante
    float peso = 50.5f;
    double outroPeso = 10.97868938698;

    // Tipo de dado booleano
    bool estaNaCaverna = true;

    // Tipo de dado caracter
    char letra = 'A';
    char numero = '2';

    // Tipo de dado string
    string nome = "José";

    void Start()
    {
        Debug.Log("Número inteiro: " +  vidaPersonagem);
        Debug.Log("Número float: " +  peso);
        Debug.Log("Número double: " +  outroPeso);
        Debug.Log("Booleano: " +  estaNaCaverna);
        Debug.Log("Caracter: " + letra);
        Debug.Log("Caracter: " + numero);
        Debug.Log("String: " + nome);
    }
}
