using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OperadoresComparacao : MonoBehaviour
{
    int a = 5;
    int b = 10;
    void Start()
    {
        Debug.Log("a == b: " + (a == b));
        Debug.Log("a != b: " + (a != b));
        Debug.Log("a > b: " + (a > b));
        Debug.Log("a < b: " + (a < b));
        Debug.Log("a >= b: " + (a >= b));
        Debug.Log("a <= b: " + (a <= b));
    }
}
