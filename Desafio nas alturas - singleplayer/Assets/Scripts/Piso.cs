using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piso : MonoBehaviour
{
    [SerializeField]
    private VariavelCompartilhadaFloat velocidade;

    private Vector3 posicaoInicial;
    private float tamanhoRealDaImagaem;

    private void Awake ()
    {
        this.posicaoInicial = this.transform.position;
        float tamanhoDaImagaem = this.GetComponent<SpriteRenderer>().size.x;
        float escala = this.transform.localScale.x;
        this.tamanhoRealDaImagaem = tamanhoDaImagaem * escala;
    }
    
    void Update()
    {
        float deslocamento = Mathf.Repeat(this.velocidade.valor * Time.time, this.tamanhoRealDaImagaem);
        this.transform.position = this.posicaoInicial + Vector3.left * deslocamento;
    }
}
