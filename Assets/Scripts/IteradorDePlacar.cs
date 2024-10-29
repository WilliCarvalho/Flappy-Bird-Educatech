using System;
using UnityEngine;

public class IteradorDePlacar : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            //Atualizar placar
        }
    }
}
