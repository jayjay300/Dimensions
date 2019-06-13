using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Player_MoveD2 : MonoBehaviour
{



    public float playerSpeed = 1;
    public bool facingRight = true,move=true;
    public int playerJumpPower = 1250;
    public float moveX,moveY;
    public float posx, posy;
    // Use this for initialization
    void Start()
    {

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Finish")
        {
            Debug.Log("test");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        if (other.transform.tag == "Block")
        {
            Debug.Log("test");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    // Update is called once per frame
    void Update()
    {
        posx = gameObject.GetComponent<Rigidbody2D>().position.x;
        posy = gameObject.GetComponent<Rigidbody2D>().position.y;
       // PlayerMove();
        if ((posx > 3.98 || posx < -4.07) || (posy > 4.7 || posy < -2.73)) //if y is greater than 6.50 or less than -4 or x is greater than 5 or less than -5
        {
            move = false;
        }
        else
        {
            playerSpeed = Mathf.Abs(playerSpeed);
            move = true;
        }

            PlayerMove();



    }

    void PlayerMove()
    {
        if (move == true)
        {
            moveX = Input.GetAxis("Horizontal");
            moveY = Input.GetAxis("Vertical");
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(moveX * playerSpeed, moveY * playerSpeed);

        }
        else
        {
            playerSpeed = playerSpeed * -1;
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(moveX * playerSpeed, moveY * playerSpeed);

        }

        
            //gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(moveY * playerSpeed, gameObject.GetComponent<Rigidbody2D>().velocity.x);
    }
}
