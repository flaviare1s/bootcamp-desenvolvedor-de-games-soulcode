using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyObjects : MonoBehaviour
{
    public GameObject targetObject;
    public GameObject fundo;
    void Start()
    {
        Vector3 position = targetObject.transform.position;
        Vector3 rotation = targetObject.transform.eulerAngles;
        Vector3 scale = targetObject.transform.localScale;

        Debug.Log("Posição do Game Object: x = " + position.x + " y = " + position.y);
        Debug.Log(position);
        Debug.Log("Rotação do Game Object: x = " + rotation.x + " y = " + rotation.y);
        Debug.Log(rotation);
        Debug.Log("Escala do Game Object: x = " + scale.x + " y = " + scale.y);
        Debug.Log(scale);

        targetObject.GetComponent<SpriteRenderer>().color = Color.blue;
        fundo.GetComponent<SpriteRenderer>().color = Color.yellow;

        targetObject.transform.position = new Vector3(9f, 0, 0);
    }
}
