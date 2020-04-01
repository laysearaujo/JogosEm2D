using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{
    private Piso[] cenario;
    private GeradorDeObstaculo obstaculo;
    private Aviao aviao;
    private bool estouMorto;

    private void Start()
    {
        this.cenario = this.GetComponentsInChildren<Piso>();
        this.obstaculo = this.GetComponentInChildren<GeradorDeObstaculo>();
        this.aviao = this.GetComponentInChildren<Aviao>();
    }

    //Desativar Cenário
    public void Desativar()
    {
        this.estouMorto = true;
        this.obstaculo.Parar();
        foreach (var piso in this.cenario)
        {
            piso.enabled = false;
        }

    }

    public void Ativar()
    {   
        if(this.estouMorto) {
            this.aviao.Reiniciar();
            this.obstaculo.Recomecar();
            foreach (var piso in this.cenario)
            {
                piso.enabled = true;
            }
            this.estouMorto = false;
        }
        
    }
}
