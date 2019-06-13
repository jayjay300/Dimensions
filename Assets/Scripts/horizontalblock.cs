using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class horizontalblock : MonoBehaviour
{
    public float playerSpeed = 1;
    public bool movingup = true;

    public float moveX = 1;
    public float posx, posy;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        PlayerMove();
        posx = gameObject.GetComponent<Rigidbody2D>().position.x;


        if (posx >= 3.8)
        {
            movingup = false;
        }
        if (posx <= -3.8)
        {

            movingup = true;
        }

    }
    void PlayerMove()
    {
        if (movingup == false)
        {
            playerSpeed = -1;
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(moveX * playerSpeed, 0);
        }
        else
        {
            playerSpeed = 1;
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(moveX * playerSpeed, 0);
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.transform.tag == "Block")
        {
            if (movingup == true)
            {
                movingup = false;
            }
            if(movingup == false)
            {

                movingup = true;
            }
        }
    }
}
