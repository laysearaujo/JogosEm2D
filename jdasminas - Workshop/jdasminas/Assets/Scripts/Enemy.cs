using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{ 

    public float speed;

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Player.health--;
            GetComponent<SpriteRenderer>().color = new Color(0, 0, 1, 1);
            Destroy(gameObject,0.4f);
        }
    }
}
