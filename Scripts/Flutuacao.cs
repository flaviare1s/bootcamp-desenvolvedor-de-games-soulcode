using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flutuacao : MonoBehaviour
{
    public Transform pontoA;
    public Transform pontoB;
    public float velocidade = 1f;
    public float alturaSalto = 0.5f;
    private Vector3 direcao;
    private float tempo = 0f;
    void Start()
    {
        direcao = (pontoB.position - pontoA.position).normalized;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direcao * velocidade * Time.deltaTime;
        float flutuacao = Mathf.Sin(tempo) * alturaSalto;
        transform.position = new Vector3(transform.position.x, pontoA.position.y + flutuacao, transform.position.z);

        tempo += Time.deltaTime * 2f;

        if (Vector2.Distance(transform.position, pontoB.position) < 1f)
        {
            //transform.position = pontoA.position;
            //tempo = 0f;
            direcao = (pontoA.position - pontoB.position).normalized;
        } else if (Vector2.Distance(transform.position, pontoA.position) < 1f)
        {
            direcao = (pontoB.position - pontoA.position).normalized;
        }
    }
}
