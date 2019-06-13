using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class verticalblock : MonoBehaviour {
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
        posy = gameObject.GetComponent<Rigidbody2D>().position.y;
        
       
        if(posy >= 3.5)
        {
            movingup = false;
        }
        if(posy <= -1.5)
        {

            movingup = true;
        }
      
    }
    void PlayerMove()
    {
        if (movingup == false)
        {
            playerSpeed = -1;
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, (moveY * playerSpeed));
        }
        else
        {
            playerSpeed = 1;
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, (moveY * playerSpeed));
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
