using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomApple:MonoBehaviour {

    public GameObject applePrefab;

    AddBodyPart addBodyPartScript;

    Vector2 spawnLocation;
    int xPos = 0, yPos = 3;

    void Start() {
        addBodyPartScript = GameObject.FindGameObjectWithTag("Player").GetComponent<AddBodyPart>();
        spawnLocation = new Vector2(xPos, yPos);

        addBodyPartScript.apple = Instantiate(applePrefab, spawnLocation, Quaternion.identity);
        addBodyPartScript.appleOnField = true;
    }

    void Update() {
        if(addBodyPartScript.appleOnField == true)
            return;

        SpawnApple();
    }

    void SpawnApple() {
        //Randomize Spawnpos
        xPos = Random.Range(-6, 6);
        yPos = Random.Range(-4, 4);
        spawnLocation = new Vector2(xPos, yPos);

        GameObject holdApple = Instantiate(applePrefab, spawnLocation, Quaternion.identity);
        addBodyPartScript.apple = holdApple;

        addBodyPartScript.appleOnField = true;
    }
}
