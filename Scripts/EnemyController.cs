using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Rigidbody2D rb;
    public List<Transform> waypoints;
    public float velocidade = 5f;
    int proximoPonto = 0;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (waypoints.Count > 0)
        {
            Vector2 direcao = (waypoints[proximoPonto].position - transform.position).normalized;
            rb.velocity = direcao * velocidade;

            if(Vector2.Distance(transform.position, waypoints[proximoPonto].position) < 0.1f)
            {
                proximoPonto = (proximoPonto + 1) % waypoints.Count;
            }
        }
    }
}
