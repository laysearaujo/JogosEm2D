using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maoPiscando : MonoBehaviour
{   private SpriteRenderer imagem;
    

    void Awake()
    {
        this.imagem = this.GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            this.Desaparecer();
        }
    }

    private void Desaparecer()
    {
        this.imagem.enabled = false;
    }
}
