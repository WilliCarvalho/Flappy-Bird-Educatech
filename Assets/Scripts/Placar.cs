using System;
using TMPro;
using UnityEngine;

public class Placar : MonoBehaviour
{
    public static Placar Instancia;

    [SerializeField] private TextMeshProUGUI textoPlacarAtual;
    [SerializeField] private TextMeshProUGUI textoMelhorPlacar;

    private int placar;

    private void Awake()
    {
        if (Instancia == null)
        {
            Instancia = this;
        }
    }

    private void Start()
    {
        textoPlacarAtual.text = placar.ToString();

        textoMelhorPlacar.text = PlayerPrefs.GetInt("MelhorPlacar", 0).ToString();
    }

    private void AtualizaMelhorPlacar()
    {
        if (placar > PlayerPrefs.GetInt("MelhorPlacar"))
        {
            PlayerPrefs.SetInt("MelhorPlacar", placar);
            textoMelhorPlacar.text = placar.ToString();
        }
    }

    public void AtualizaPlacar()
    {
        placar++;
        textoPlacarAtual.text = placar.ToString();
        AtualizaMelhorPlacar();
    }
}
