using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossController : MonoBehaviour {

    public GameObject txt;
    public PlayerController player;

    void Start() {
        player = (PlayerController)FindObjectOfType(typeof(PlayerController));
        txt.GetComponent<UnityEngine.UI.Text>().text = "Not Enough!";
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player") {
            if (player.counter == 17){
                txt.GetComponent<UnityEngine.UI.Text>().text = "Congratilations!";
            }
        
        }
    }
}
