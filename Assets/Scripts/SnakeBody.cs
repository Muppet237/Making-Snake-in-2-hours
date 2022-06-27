using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeBody:MonoBehaviour {

    public GameObject parentObject;

    Vector3 savePlayerPos;

    void Start() {
        savePlayerPos = parentObject.transform.position;
    }

    void Update() {
        if(savePlayerPos == parentObject.transform.position)
            return;

        transform.position = savePlayerPos;
        savePlayerPos = parentObject.transform.position;
    }
}
