using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Player_Movement : MonoBehaviour {



    public float playerSpeed = 1;
    public bool facingRight = true;
    public int playerJumpPower = 1250;
    public float moveX;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        PlayerMove();

	}

    void PlayerMove()
    {

        moveX = Input.GetAxis("Horizontal");
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(moveX * playerSpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Finish")
        {
            Debug.Log("test");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }
}
