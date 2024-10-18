using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataTypesExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int intergerExample = 10;
        float floatExample = 15.5f;
        double doubleExample = 30.5478;
        bool boolExample = true;
        string stringExample = "Hello, World!";

        Debug.Log("Integer: " +  intergerExample);
        Debug.Log("Float: " + floatExample);
        Debug.Log("Double: " + doubleExample);
        Debug.Log("Bool: " + boolExample);
        Debug.Log("String: " + stringExample);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
