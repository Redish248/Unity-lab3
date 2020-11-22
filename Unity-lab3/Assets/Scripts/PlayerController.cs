using UnityEngine;

public class PlayerController : MonoBehaviour {
    
    public float speed = 20f;
    private Rigidbody2D rb;
    private bool faceRight = true;
   // public string score = "Score: ";

    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update() {
        float moveX = Input.GetAxis("Horizontal");
        rb.MovePosition(rb.position + Vector2.right * moveX * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            rb.AddForce(Vector2.up * 8000);
        }

        if (moveX > 0  && !faceRight) {
            flip();
        } else if (moveX < 0 && faceRight) {
            flip();
        }

        //PhotonNetwork.player.name = score;

    }


    void flip() {
        faceRight = !faceRight;
        transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
    }

    //void OnGUI(){
    //     score = GUI.TextField(new Rect(Screen.width / 2 - 50, Screen.height / 2, 100, 20), PlayerName);
     //}

}
