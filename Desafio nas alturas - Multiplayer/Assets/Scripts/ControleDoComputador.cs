using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleDoComputador : MonoBehaviour
{

    [SerializeField]
    private float intervalo;

    private Aviao aviao;

    void Start()
    {
        this.aviao = this.GetComponent<Aviao>();
        StartCoroutine(this.Impulsionar());
    }


    //IEnumerator é o retono do yield return
    private IEnumerator Impulsionar()
    {   
        this.aviao.DarImpulso();
        while(true){
        yield return new WaitForSeconds(this.intervalo); //parar a função por 0,5s e logo em seguinda volta a função para continuar na linha seguinte
        this.aviao.DarImpulso();
        }
    }
}
