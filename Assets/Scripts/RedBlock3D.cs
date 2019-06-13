using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBlock3D : MonoBehaviour {


    public float playerSpeed = 1;
    public bool movingup;

    public float moveX = 1;
    public float posx, posz;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();

        posx = gameObject.GetComponent<Rigidbody>().position.x;


        if (posx >= 3)
        {
            movingup = false;
        }
        if (posx <= -3)
        {

            movingup = true;
        }
    }

    void PlayerMove()
    {
        if (movingup == false)
        {
            playerSpeed = -1;
            gameObject.GetComponent<Rigidbody>().velocity = new Vector3(moveX * playerSpeed, 0,0);
        }
        else
        {
            playerSpeed = 1;
            gameObject.GetComponent<Rigidbody>().velocity = new Vector3(moveX * playerSpeed, 0, 0);
        }
    }
    void OnTriggerEnter(Collider other)
    {


        if (movingup == true)
        {
            movingup = false;
        }
        if (movingup == false)
        {

            movingup = true;
        }

    }
}
