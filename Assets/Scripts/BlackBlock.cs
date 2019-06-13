using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackBlock : MonoBehaviour {


    public float playerSpeed = 1;
    public bool movingup;

    public float moveZ = 1;
    public float posx, posz;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        PlayerMove();

        posz = gameObject.GetComponent<Rigidbody>().position.z;


        if (posz >= 2)
        {
            movingup = false;
        }
        if (posz <= -8)
        {

            movingup = true;
        }
    }

    void PlayerMove()
    {
        if (movingup == false)
        {
            playerSpeed = -1;
            gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0,0, moveZ * playerSpeed);
        }
        else
        {
            playerSpeed = 1;
            gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0,0,moveZ * playerSpeed);
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
