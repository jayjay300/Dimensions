using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Character3D : MonoBehaviour {
    public float walkspeed = 1f;
    public float jumpspeed = 1f;
    public float posy;
    public float dead = 0;
    private bool isGrounded;
    Rigidbody rb;
    Collider coll;
    

    bool pressedJump = false;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        coll = GetComponent<Collider>();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Finish")
        {
            Debug.Log("test");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        if (other.transform.tag == "Block")
        {
            Debug.Log("test");
            
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }
    // Update is called once per frame
    void Update () {
        posy = gameObject.GetComponent<Rigidbody>().position.y;
        
        if(posy< dead)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        }
        WalkHandler();
        JumpHandler();
        
    }

    void WalkHandler()
    {


        
        rb.velocity = new Vector3(0, rb.velocity.y, 0);
        float distance = walkspeed * Time.deltaTime;

        float hAxis = Input.GetAxis("Horizontal");
        float vAxis = Input.GetAxis("Vertical");


        Vector3 movement = new Vector3(vAxis * -distance, 0f, hAxis * distance);

        Vector3 currPosition = transform.position;

        Vector3 newPosition = currPosition + movement;


        rb.MovePosition(newPosition);

    }

    void JumpHandler()
    {
        // Jump axis
        float jAxis = Input.GetAxis("Jump");


        if (SceneManager.GetActiveScene().name.ToString() != "D7")
        {
            isGrounded = CheckGrounded();
        }
        else
        {
           isGrounded = true;

        }

        if (jAxis > 0f)
        {

            if (pressedJump==false && isGrounded == true)
            {
                pressedJump = true;
                // Jumping vector
                Vector3 jumpVector = new Vector3(0f, jumpspeed, 0f);

                // Make the player jump by adding velocity
                rb.velocity = rb.velocity + jumpVector;

            }
           
        }
        else
        {

            pressedJump = false;
        }
    }
    bool CheckGrounded()
    {
        // Object size in x
        float sizeX = coll.bounds.size.x;
        float sizeZ = coll.bounds.size.z;
        float sizeY = coll.bounds.size.y;

        // Position of the 4 bottom corners of the game object
        // We add 0.01 in Y so that there is some distance between the point and the floor
        Vector3 corner1 = transform.position + new Vector3(sizeX / 2, -sizeY / 2 + 0.01f, sizeZ / 2);
        Vector3 corner2 = transform.position + new Vector3(-sizeX / 2, -sizeY / 2 + 0.01f, sizeZ / 2);
        Vector3 corner3 = transform.position + new Vector3(sizeX / 2, -sizeY / 2 + 0.01f, -sizeZ / 2);
        Vector3 corner4 = transform.position + new Vector3(-sizeX / 2, -sizeY / 2 + 0.01f, -sizeZ / 2);

        // Send a short ray down the cube on all 4 corners to detect ground
        bool grounded1 = Physics.Raycast(corner1, new Vector3(0, -1, 0), 0.01f);
        bool grounded2 = Physics.Raycast(corner2, new Vector3(0, -1, 0), 0.01f);
        bool grounded3 = Physics.Raycast(corner3, new Vector3(0, -1, 0), 0.01f);
        bool grounded4 = Physics.Raycast(corner4, new Vector3(0, -1, 0), 0.01f);

        // If any corner is grounded, the object is grounded
        return (grounded1 || grounded2 || grounded3 || grounded4);
    }
}
