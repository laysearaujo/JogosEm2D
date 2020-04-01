using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{   
    public float velocidade;

    private void Awake() 
    {
        this.transform.Translate(Vector3.up * Random.Range(-1, 1));
    }

    void Update()
    {
        this.transform.Translate(Vector3.left * this.velocidade * Time.deltaTime);

        
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {   
        if(other.CompareTag("Parede")){
            this.Destruir();
        }
        
    }

    public void Destruir()
    {
        GameObject.Destroy(this.gameObject);
    }
}
