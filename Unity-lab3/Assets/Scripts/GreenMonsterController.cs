using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenMonsterController : MonoBehaviour {
    private Rigidbody2D rb;
    public GameObject respawn;
    private bool moveLeft = true;

    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update() {

        if (transform.position.x >= 2.5 && moveLeft) {
            transform.Translate(Vector3.left * Time.deltaTime);
        }

        if (transform.position.x <= 5.3 && !moveLeft) {
            transform.Translate(Vector3.right * Time.deltaTime);
        }

        if (transform.position.x >= 5.3) {
            moveLeft = true;
        }

        if (transform.position.x <= 2.5) {
            moveLeft = false;
        }


    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player") {
            other.transform.position = respawn.transform.position;
        }
    }

}
