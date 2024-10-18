using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuga : MonoBehaviour
{
    public Transform pontoA;
    public Transform pontoB;
    public float velocidade = 1f;
    private Vector3 direcao;
    void Start()
    {
        direcao = (pontoB.position - pontoA.position).normalized;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direcao * velocidade * Time.deltaTime;
    }
}
