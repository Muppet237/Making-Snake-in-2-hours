using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddBodyPart:MonoBehaviour {

    public GameObject prefab, apple;
    GameObject saveParent;

    public bool appleOnField;

    void Start() {
        saveParent = GameObject.FindGameObjectWithTag("Player");
    }

    void Update() {
        if(!appleOnField)
            return;

        if(apple.transform.position != transform.position)
            return;

        AddPart();
    }

    void AddPart() {
        GameObject tempParent = Instantiate(prefab, saveParent.transform.position, Quaternion.identity);
        SnakeBody bodyScript = tempParent.GetComponent<SnakeBody>();
        bodyScript.parentObject = saveParent;
        saveParent = tempParent;
        appleOnField = false;
        Destroy(apple);
    }
}
