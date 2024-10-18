using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour
{
    int vida = 150;
    int danoInimigo = 25;
    string nomePersonagem = "Goblin";
    void Start()
    {
        Debug.Log(nomePersonagem + " tem " + vida + " de vida e causa " +  danoInimigo + " de dano.");
    }
}
