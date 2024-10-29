using UnityEngine;

public class MoveCano : MonoBehaviour
{
    [SerializeField] private float velocidade = 0.65f;

    void Update()
    {
        transform.position += Vector3.left * velocidade * Time.deltaTime;
    }
}
