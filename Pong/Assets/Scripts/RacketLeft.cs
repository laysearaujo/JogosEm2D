using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketLeft : MonoBehaviour {
 
    public float speed;
    public string axis;
    
    void Start() {
        
    }

    void Update() {
        
    }

    void FixedUpdate() {
        float v = Input.GetAxisRaw(axis);
        GetComponent<Rigidbody2D>().velocity = new Vector2 (0, v) * speed;
    }
}
