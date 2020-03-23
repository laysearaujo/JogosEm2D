using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diretor : MonoBehaviour
{   
    [SerializeField]
    private GameObject image;
    private Aviao aviao;
    private Pontuacao pontuacao;

    private void Start()
    {
        this.aviao = GameObject.FindObjectOfType<Aviao>();
        this.pontuacao = GameObject.FindObjectOfType<Pontuacao>();
    }

   public void finalizarJogo()
   {
       Time.timeScale = 0;
       this.image.SetActive(true);
   }

   public void ReinicializarJogo()
   {
       this.image.SetActive(false);
       Time.timeScale = 1;
       this.aviao.Reiniciar();
       this.DestruirObstaculos();
       this.pontuacao.Reiniciar();
   }

   private void DestruirObstaculos() 
   {
       Obstaculo[] obstaculos = GameObject.FindObjectsOfType<Obstaculo>();
       foreach (Obstaculo obstaculo in obstaculos)
       {
           obstaculo.Destruir();
       }
   }
}
