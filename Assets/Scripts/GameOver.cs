using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver:MonoBehaviour {


    void Start() {
    }

    void Update() {
        if(transform.position.x == -7 || transform.position.x == 7)
            PauseGame();

        if(transform.position.y == -5 || transform.position.y == 5)
            PauseGame();
    }

    void PauseGame() {
        Time.timeScale = 0;
    }
}
