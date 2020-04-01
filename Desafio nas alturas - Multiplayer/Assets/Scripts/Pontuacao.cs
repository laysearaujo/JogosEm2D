using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Pontuacao : MonoBehaviour
{   
    [SerializeField]
    private Text textopontuacao;
    [SerializeField]
    private UnityEvent aoPontuar;

    public int Pontos { get; private set; }
    private AudioSource audioPontuacao;

    private void Awake() {
        this.audioPontuacao = this.GetComponent<AudioSource>();
    }

    public void addPontos() 
    {
        this.Pontos++;
        this.textopontuacao.text = this.Pontos.ToString();
        this.audioPontuacao.Play();
        this.aoPontuar.Invoke();
    }

    public void Reiniciar()
    {
        this.Pontos = 0;
        this.textopontuacao.text = this.Pontos.ToString();
    }

    public void SalvarRecorde()
    {
        int recordeAtual = PlayerPrefs.GetInt("recorde");
        if(this.Pontos > recordeAtual)
        {
            PlayerPrefs.SetInt("recorde", this.Pontos);
        }
        
    }
}
