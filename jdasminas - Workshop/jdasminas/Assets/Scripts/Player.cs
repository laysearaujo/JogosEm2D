using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    private float speed = 200;
    private  float increment = 5;
    private float maxY = 5;
    private float minY = -5;
    private Vector2 targetPos;
    public static int health = 3;
    public Text healthDisplay;
    public GameObject restartDisplay, spawner;
    public AudioSource soundEnemy;

    private void Update()
    {

        if (health <= 0)
        {
           spawner.SetActive(false);
            restartDisplay.SetActive(true);
            Destroy(gameObject);
        }
    
        healthDisplay.text ="Life: "+ health.ToString();

        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxY)
        {

            targetPos = new Vector2(transform.position.x, transform.position.y + increment);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minY)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y - increment);
        }
    }

    
   /* private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("enemy"))
        {
            soundEnemy.Play();
        }
      
    }*/
}
