using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiretorMultiplayer : Diretor
{
    [SerializeField]
    private int pontosParaReviver;

    private Jogador[] jogadores;
    private bool alguemMorto;
    private int pontosDesdeAMorte;
    private InterfaceDoCanvasInativo interfaceInativo;

    protected override void Start()
    {
        base.Start();
        this.jogadores = GameObject.FindObjectsOfType<Jogador>();
        this.interfaceInativo = GameObject.FindObjectOfType<InterfaceDoCanvasInativo>();
    }

    public void AvisarQueAlguemMorreu(Camera camera)
    {
        if(this.alguemMorto) {
            this.finalizarJogo();
            this.interfaceInativo.Sumir();
        }else {
            this.alguemMorto = true;
            this.pontosDesdeAMorte = 0;
            this.interfaceInativo.AtualizarTexto(this.pontosParaReviver);
            this.interfaceInativo.Mostrar(camera);
        }
        
    }

    public void ReviverSePrecisar()
    {
        if(this.alguemMorto) {
            this.pontosDesdeAMorte++;
            this.interfaceInativo.AtualizarTexto(this.pontosParaReviver - this.pontosDesdeAMorte);
            if(this.pontosDesdeAMorte >= pontosParaReviver) {
                this.interfaceInativo.Sumir();
                this.ReviverJogadores();
            }
        }
    }

    private void ReviverJogadores()
    {
        this.alguemMorto = false;
        foreach (var jogador in this.jogadores)
        {
            jogador.Ativar();
        }
    }

    public override void ReinicializarJogo()
    {
        base.ReinicializarJogo();
        this.ReviverJogadores();
    }
}
