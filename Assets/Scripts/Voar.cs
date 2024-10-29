using System;
using UnityEngine;

public class Voar : MonoBehaviour
{
    [SerializeField] private float velocidade = 1.5f;
    [SerializeField] private float velocidadeRotacao = 12f;
    
    private Rigidbody2D rigidbody2D; 
    
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            rigidbody2D.velocity = Vector2.up * velocidade;
        }
    }

    private void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0, 0, rigidbody2D.velocity.y * velocidadeRotacao);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        GerenciaJogo.Instancia.FimDeJogo();
    }
}
