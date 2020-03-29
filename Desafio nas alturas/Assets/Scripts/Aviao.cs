﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aviao : MonoBehaviour
{
    private Rigidbody2D fisica;

    public float forca = 10;
    private Diretor diretor;
    private bool deveImpulsionar = false;
    private Animator animacao;

    private Vector3 posicaoInicial;

    private void Awake()
    {
        this.posicaoInicial = this.transform.position;
        this.fisica = this.GetComponent<Rigidbody2D>(); 
        this.animacao = this.GetComponent<Animator>(); 
    }

    private void Start() 
    {
            this.diretor = GameObject.FindObjectOfType<Diretor>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            this.deveImpulsionar = true;
        }
        this.animacao.SetFloat("VelocidadeY", this.fisica.velocity.y);
    }

    private void FixedUpdate() 
    {
        if(this.deveImpulsionar == true)
        {
            this.Impulsionar();
        }
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

    private void OnCollisionEnter2D(Collision2D other) 
    {
        this.fisica.simulated = false;
        this.diretor.finalizarJogo();
    }

}

