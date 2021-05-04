using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {
   void Update()
    {

        Invoke("RestartGame", 2);

    }

    void RestartGame()
    {
        Player.health = 3;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
