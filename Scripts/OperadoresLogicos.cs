using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OperadoresLogicos : MonoBehaviour
{
    int a = 10;
    int b = 5;
    void Start()
    {
        bool resultado1 = (a < b) && (a > 12);
        Debug.Log(resultado1);

        bool resultado2 = (a == 10) || (b == 15);
        Debug.Log(resultado2);

        bool resultado3 = !resultado1;
        Debug.Log(resultado3);
    }
}
