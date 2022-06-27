using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement:MonoBehaviour {

    float offset = 0.5f;

    public enum movementInputs { Left, Right, Up, Down };
    public movementInputs currentDirection;

    void Start() {
        currentDirection = movementInputs.Up;
        StartCoroutine(movePlayer());
    }

    void Update() {
        //Right
        if(Input.GetKeyDown(KeyCode.D))
            currentDirection = movementInputs.Right;

        //Left
        if(Input.GetKeyDown(KeyCode.A))
            currentDirection = movementInputs.Left;

        //Up
        if(Input.GetKeyDown(KeyCode.W))
            currentDirection = movementInputs.Up;

        //Down
        if(Input.GetKeyDown(KeyCode.S))
            currentDirection = movementInputs.Down;
    }

    IEnumerator movePlayer() {
        yield return new WaitForSeconds(.5f);

        switch(currentDirection) {
            case movementInputs.Left:
                transform.position -= transform.right * offset;
                break;
            case movementInputs.Right:
                transform.position += transform.right * offset;
                break;
            case movementInputs.Up:
                transform.position += transform.up * offset;
                break;
            case movementInputs.Down:
                transform.position -= transform.up * offset;
                break;
        }
        StartCoroutine(movePlayer());
    }
}
