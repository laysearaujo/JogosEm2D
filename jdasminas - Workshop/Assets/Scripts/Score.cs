﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public int score;
    public Text scoreDisplay;

    private void Update()
    {
        if(Player.health > 0)
        {
            scoreDisplay.text = "Score: " +score.ToString();
        }
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        score++;
        Destroy(other.gameObject);
    }
}
