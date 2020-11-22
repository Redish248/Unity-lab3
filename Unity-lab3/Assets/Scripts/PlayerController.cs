using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {
    
    public float speed = 15f;
    private Rigidbody2D rb;
    private bool faceRight = true;
    public int counter = 0;

    public GameObject txt;

    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update() {
        float moveX = Input.GetAxis("Horizontal");
        rb.MovePosition(rb.position + Vector2.right * moveX * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.UpArrow)) {
           rb.AddForce(Vector2.up * 5000);
        }

        if (moveX > 0  && !faceRight) {
            flip();
        } else if (moveX < 0 && faceRight) {
            flip();
        }

        txt.GetComponent<UnityEngine.UI.Text>().text = "Score: " + counter;

    }


    void flip() {
        faceRight = !faceRight;
        transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
    }

}
