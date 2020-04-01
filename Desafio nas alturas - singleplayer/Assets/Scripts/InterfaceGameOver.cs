using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterfaceGameOver : MonoBehaviour
{
    [SerializeField]
    private Text ValorRecorde;
    [SerializeField]
    private GameObject image;

    private Pontuacao pontuacao;
    private int recorde;

    [SerializeField]
    private Image posicaoMedalha;
    [SerializeField]
    private Sprite medalhaOuro;
    [SerializeField]
    private Sprite medalhaPrata;
    [SerializeField]
    private Sprite medalhaBronze;

    private void Start() 
    {
        this.pontuacao = GameObject.FindObjectOfType<Pontuacao>();    
    }

    public void MostrarInterface()
    {
        this.AtualizarInterfaceGrafica();
        this.image.SetActive(true);
    }

    public void Esconder()
    {
        this.image.SetActive(false);
    }
    
    private void AtualizarInterfaceGrafica()
    {
        this.recorde = PlayerPrefs.GetInt("recorde");
        this.ValorRecorde.text = recorde.ToString();
        this.VerificarcorMedalha();
    }

    private void VerificarcorMedalha()
    {
        if (this.pontuacao.Pontos > this.recorde-2) {
            //Ouro
            this.posicaoMedalha.sprite = this.medalhaOuro;
        }else if (this.pontuacao.Pontos > this.recorde/2) {
            //prata
            this.posicaoMedalha.sprite = this.medalhaPrata;
        }else {
            //Bronze
            this.posicaoMedalha.sprite = this.medalhaBronze;
        }

    }

}
