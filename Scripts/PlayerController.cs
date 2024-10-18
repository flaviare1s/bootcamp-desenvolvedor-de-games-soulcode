using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocidade = 5f;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float eixoX = Input.GetAxisRaw("Horizontal") * velocidade;
        float eixoY = Input.GetAxisRaw("Vertical") * velocidade;
        rb.velocity = new Vector2(eixoX, eixoY);
    }
}
