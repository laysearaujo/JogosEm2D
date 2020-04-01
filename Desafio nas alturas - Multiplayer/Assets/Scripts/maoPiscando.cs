using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maoPiscando : MonoBehaviour
{  
    [SerializeField]
    private KeyCode tecla;
    
    private SpriteRenderer imagem;
    

    void Awake()
    {
        this.imagem = this.GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if(Input.GetKeyDown(this.tecla)) {
            this.Desaparecer();
        }
    }

    private void Desaparecer()
    {
        this.imagem.enabled = false;
    }
}
