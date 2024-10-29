using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class GeraCano : MonoBehaviour
{
    [SerializeField] private float tempoMaximo = 1.5f;
    [SerializeField] private float variacaoAltura = 0.45f;
    [SerializeField] private MoveCano referenciaCano;

    private float temporizador = 0;
    // Start is called before the first frame update
    void Start()
    {
        GerarCano();
    }


    // Update is called once per frame
    void Update()
    {
        if (temporizador > tempoMaximo)
        {
            GerarCano();
            temporizador = 0;
        }

        temporizador += Time.deltaTime;
    }
    
    private void GerarCano()
    {
        Vector3 PosicaoDoCanoGerado =
            transform.position + new Vector3(0, Random.Range(-variacaoAltura, variacaoAltura));
        MoveCano cano = Instantiate(referenciaCano, PosicaoDoCanoGerado, quaternion.identity);
        
        Destroy(cano.gameObject, 5f);
    }
}
