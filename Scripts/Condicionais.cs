using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Condicionais : MonoBehaviour
{
    void Start()
    {   // If-else
        int numero = 10;
        if (numero > 0)
        {
            Debug.Log("O número é positivo");
        } else
        {
            Debug.Log("O número é negativo");
        }

        // If-elseif-else
        int temperatura = 30;
        if (temperatura > 30)
        {
            Debug.Log("Está muito quente!");
        } else if (temperatura < 10)
        {
            Debug.Log("Está muito frio!");
        } else
        {
            Debug.Log("A temperatura está agradável!");
        }

        // Mais exemplos
        int idade = 18;
        if (idade >= 18)
        {
            Debug.Log("Você é maior de idade!");
        } else
        {
            Debug.Log("Você é menor de idade!");
        }

        string diaDaSemana = "Sexta";
        if (diaDaSemana == "Sábado" ||  diaDaSemana == "Domingo")
        {
            Debug.Log("Hoje é dia de descansar!");
        } else
        {
            Debug.Log("Hoje é dia de trabalhar!");
        }

        // Operador ternário
        int numeroAlunos = 10;
        string resultado = (numeroAlunos >= 10) ? "Turma cheia!" : "Ainda tem vaga!";
        Debug.Log(resultado);

        bool estaAprovado = true;
        string status = estaAprovado ? "Aprovado!" : "Reprovado!";
        Debug.Log(status);

        // Switch-case
        int nivel = 2;
        switch (nivel)
        {
            case 1:
                Debug.Log("você está no nível 1");
                break;
            case 2:
                Debug.Log("Você está no nível 2");
                break;
            case 3:
                Debug.Log("Você está no nível 3");
                break;
            default:
                Debug.Log("Nível desconhecido!");
                break;
        }

        string cor = "amarelo";
        switch (cor)
        {
            case "vermelho":
                Debug.Log("A cor é vermelho");
                break;
            case "azul":
                Debug.Log("A cor é azul");
                break;
            case "verde":
                Debug.Log("A cor é verde");
                break;
            default:
                Debug.Log("Cor não conhecida");
                break;
        }
    }
}
