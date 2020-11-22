using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueMonsterController : MonoBehaviour {
    private Rigidbody2D rb;

    public GameObject respawn;

    private bool moveTop = true;

    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update() {
        if (transform.position.y <= 1 && moveTop) {
            transform.Translate(Vector3.up * Time.deltaTime);
        }

        if (transform.position.y >= -1 && !moveTop) {
            transform.Translate(Vector3.down * Time.deltaTime);
        }

        if (transform.position.y >= 1) {
            moveTop = false;
        }

        if (transform.position.y <= -1) {
            moveTop = true;
        }
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player") {
            other.transform.position = respawn.transform.position;
        }
    }

}
