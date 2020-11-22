using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowMonsterController : MonoBehaviour {
    public PlayerController player;
    private bool toDestroy = false;
    private bool isAdded = false;

    void Start() {
        player = (PlayerController)FindObjectOfType(typeof(PlayerController));
    }

    void Update() {
        if (toDestroy) {
            Destroy(this.gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player") {
            if (!isAdded) {
                player.counter += 1;
                toDestroy = true;
                isAdded = true;
            }
        }
    }

}
