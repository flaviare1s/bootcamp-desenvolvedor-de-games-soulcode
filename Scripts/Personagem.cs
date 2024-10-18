using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personagem : MonoBehaviour
{
    int vida = 100;
    string nomePersonagem = "Crazy Robot";

    void Start()
    {
        Debug.Log(nomePersonagem + " tem " + vida + " de vida.");
    }
}
