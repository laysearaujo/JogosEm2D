using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Aviao : MonoBehaviour
{
    [SerializeField]
    private UnityEvent aoBater;
    [SerializeField]
    private UnityEvent aoPassarPeloObstaculo;

    private Rigidbody2D fisica;

    public float forca = 10;
    private bool deveImpulsionar = false;
    private Animator animacao;

    private Vector3 posicaoInicial;

    private void Awake()
    {
        this.posicaoInicial = this.transform.position;
        this.fisica = this.GetComponent<Rigidbody2D>(); 
        this.animacao = this.GetComponent<Animator>(); 
    }

   
    void Update()
    {
        this.animacao.SetFloat("VelocidadeY", this.fisica.velocity.y);
    }

    private void FixedUpdate() 
    {
        if(this.deveImpulsionar == true)
        {
            this.Impulsionar();
        }
    }

    public void DarImpulso ()
    {
        this.deveImpulsionar = true;
    }
    public void Reiniciar()
    {
        this.transform.position = this.posicaoInicial;
        this.fisica.simulated = true;
    }
    
    private void Impulsionar()
    {
        this.fisica.velocity = Vector2.zero;
        this.fisica.AddForce(Vector2.up * this.forca, ForceMode2D.Impulse);
        this.deveImpulsionar = false;
    }

    //quando o OnTrigger é ativado não entra nessa função
    private void OnCollisionEnter2D(Collision2D other) 
    {
        this.fisica.simulated = false;
        this.aoBater.Invoke();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        this.aoPassarPeloObstaculo.Invoke();
    }

}

