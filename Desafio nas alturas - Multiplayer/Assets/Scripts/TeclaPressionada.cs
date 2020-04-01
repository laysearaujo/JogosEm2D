using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TeclaPressionada : MonoBehaviour
{
    
    [SerializeField]
    private KeyCode tecla;
    [SerializeField]
    private UnityEvent aoPressionarTecla;
    
    void Update()
    {
        if(Input.GetKeyDown(this.tecla)) {
            this.aoPressionarTecla.Invoke();
        }
    }

    private void DarImpulso()
    {

    }
}
