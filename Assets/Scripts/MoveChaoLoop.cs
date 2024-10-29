using System;
using UnityEngine;

public class MoveChaoLoop : MonoBehaviour
{
    [SerializeField] private float velocidade = 1f;
    [SerializeField] private float largura = 6f;

    private SpriteRenderer spriteRenderer;

    private Vector2 tamanhoInicial;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        tamanhoInicial = new Vector2(spriteRenderer.size.x, spriteRenderer.size.y);
    }

    private void Update()
    {
        spriteRenderer.size = new Vector2(spriteRenderer.size.x + velocidade * Time.deltaTime, spriteRenderer.size.y);

        if (spriteRenderer.size.x > largura)
        {
            spriteRenderer.size = tamanhoInicial;
        }
    }
}
