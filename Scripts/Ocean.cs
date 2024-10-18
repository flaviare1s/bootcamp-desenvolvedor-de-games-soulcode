using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ocean : MonoBehaviour
{
    public GameObject peixes;
    public GameObject fundo;
    public GameObject plataforma;
    void Start()
    {
        Vector3 peixe1Position = peixes.transform.position;

        peixes.transform.position = new Vector3(100f, 0, 0);
        fundo.GetComponent<SpriteRenderer>().color = Color.black;
        plataforma.GetComponent<SpriteRenderer>().color = Color.black;
    }
}
