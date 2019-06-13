using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class verticalblock3D : MonoBehaviour {
    public float playerSpeed = 1;
    public bool movingup = true;
 
    public float moveY = 1;
    public float posx, posy;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


        PlayerMove();
        posy = gameObject.GetComponent<Rigidbody>().position.y;
        
       
        if(posy >= 3)
        {
            movingup = false;
        }
        if(posy <= 7)
        {

            movingup = true;
        }
      
    }
    void PlayerMove()
    {
        if (movingup == false)
        {
            playerSpeed = -1;
            gameObject.GetComponent<Rigidbody>().velocity = new Vector2(0, (moveY * playerSpeed));
        }
        else
        {
            playerSpeed = 1;
            gameObject.GetComponent<Rigidbody>().velocity = new Vector2(0, (moveY * playerSpeed));
        }
 }

   /* void OnTriggerEnter2D(Collider2D other)
    {

        if (other.transform.tag == "Block")
        {
            if (movingup==true)
            {
                movingup = false;
            }
            if(movingup==false)
            {

                movingup = true;
            }
        }
    } */
}
