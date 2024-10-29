using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GerenciaJogo : MonoBehaviour
{
    public static GerenciaJogo Instancia;

    [SerializeField] private GameObject telaFimDeJogo;

    private void Awake()
    {
        if (Instancia == null)
        {
            Instancia = this;
        }

        Time.timeScale = 1;
    }

    public void FimDeJogo()
    {
        telaFimDeJogo.SetActive(true);

        Time.timeScale = 0f;
    }

    public void ReiniciaJogo()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
