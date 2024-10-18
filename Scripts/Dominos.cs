using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dominos : MonoBehaviour
{
    int massaEsfera = 40;
    void Start()
    {
        if (massaEsfera >= 13 && massaEsfera < 17)
        {
            Debug.Log("Pelo menos 1 dominó caiu da plataforma!");
        } else if (massaEsfera >= 17 && massaEsfera < 27)
        {
            Debug.Log("Pelo menos 2 dominós cairam da plataforma!");
        } else if (massaEsfera >= 27 && massaEsfera < 39)
        {
            Debug.Log("Os 4 dominós que estão de frente para a câmera caíram da plataforma!");
        } else if (massaEsfera >= 39)
        {
            Debug.Log("Tudo caiu da plataforma!");
        } else
        {
            Debug.Log("É preciso aumentar a massa da esfera!");
        }
    }
}
