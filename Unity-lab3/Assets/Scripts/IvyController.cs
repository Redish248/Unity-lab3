using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IvyController : MonoBehaviour {

    private float currentY;

    void Start() {
        currentY = transform.position.y;
    }

    void Update() {
        if (transform.position.y < currentY) {
            transform.position = transform.position + new Vector3(0, 0.01f, 0);
        }
    }

     void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player") {
            transform.position = transform.position + new Vector3(0, -0.2f, 0);
        }
    }
}
