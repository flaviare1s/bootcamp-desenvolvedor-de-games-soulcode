using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float velocidade;
    public float forcaPulo;
    public Transform verificadorDeChao;
    public LayerMask camadaDoChao;
    private bool estaNoChao;
    private Rigidbody2D rb;
    private bool viradoParaDireita = true;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Mover();
        Pular();
        Virar();
    }

    void Mover()
    {
        float entradaMovimento = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(entradaMovimento * velocidade, rb.velocity.y);
    }

    void Pular()
    {
        estaNoChao = Physics2D.OverlapCircle(verificadorDeChao.position, 0.2f, camadaDoChao);
        if (estaNoChao && Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x, forcaPulo);
        }
    }

    void Virar()
    {
        float entradaMovimento = Input.GetAxis("Horizontal");

        if (entradaMovimento > 0 && !viradoParaDireita)
        {
            Flipar();
        } else if (entradaMovimento < 0 && viradoParaDireita)
        {
            Flipar();
        }

    }

    void Flipar()
    {
        viradoParaDireita = !viradoParaDireita;
        Vector3 escalaLocal = transform.localScale;
        escalaLocal.x *= -1;
        transform.localScale = escalaLocal;
    }
}
