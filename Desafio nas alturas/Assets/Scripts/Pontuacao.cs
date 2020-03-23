using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pontuacao : MonoBehaviour
{
    private int pontos;
    [SerializeField]
    private Text textopontuacao;
    private AudioSource audioPontuacao;

    private void Awake() {
        this.audioPontuacao = this.GetComponent<AudioSource>();
    }

    public void addPontos() 
    {
        this.pontos++;
        this.textopontuacao.text = this.pontos.ToString();
        this.audioPontuacao.Play();
    }

    public void Reiniciar()
    {
        this.pontos = 0;
        this.textopontuacao.text = this.pontos.ToString();
    }
}
