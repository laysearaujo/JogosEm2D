using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{   
    public float velocidade;
    private Vector3 posicaodoAviao;
    private bool pontuei;
    private Pontuacao pontuacao;

    private void Awake() 
    {
        this.transform.Translate(Vector3.up * Random.Range(-1, 1));
    }

    private void Start() 
    {
        this.posicaodoAviao = GameObject.FindObjectOfType<Aviao>().transform.position;  
        this.pontuacao = GameObject.FindObjectOfType<Pontuacao>();  
    }   
    void Update()
    {
        this.transform.Translate(Vector3.left * this.velocidade);

        if(!this.pontuei && this.transform.position.x < this.posicaodoAviao.x) 
        {
            this.pontuei = true;
            this.pontuacao.addPontos();
        }
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        this.Destruir();
    }

    public void Destruir()
    {
        GameObject.Destroy(this.gameObject);
    }
}
