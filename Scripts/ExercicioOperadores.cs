using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExercicioOperadores : MonoBehaviour
{
    void Start()
    {
        int moedas = 50;
        moedas += 20;
        moedas -= 15;
        int moedasInicio = 50;
        int moedasRecebidas = 20;
        int moedasPerdidas = 15;
        int moedasFim = moedasInicio + moedasRecebidas - moedasPerdidas;
        int poderAtaque = 10;
        int poderHabilidadeEspecial = poderAtaque * 2;
        int xpJogador = 25;
        int pontosPorNivel = 7;
        int pontosExcedentes = xpJogador % pontosPorNivel;
        int xpRestante = pontosPorNivel - pontosExcedentes;

        Debug.Log("Exercício 1: O número final de moedas do jogador é " + moedas);
        Debug.Log("Exercício 1: O número final de moedas do jogador é " + moedasFim);
        Debug.Log("Exercício 2: O poder de ataque final usando a habilidade especial é " + poderHabilidadeEspecial);
        Debug.Log("Exercício 3: Faltam " + xpRestante + " pontos para o próximo nível.");
    }

}
