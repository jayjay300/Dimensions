using System.Collections;
using UnityEngine;


public class CompleteCameraController : MonoBehaviour
{

    public GameObject player, playerforRotation;//Public variable to store a reference to the player game object
    public Vector3 playerlocation;
    //public Quaternion playerrotation,newplayerrotation;
    public float hAxis, vAxis, ypos;
    private Vector3 offset;         //Private variable to store the offset distance between the player and camera
    public int speedMod = 1;

    // Use this for initialization
    void Start()
    {
        ypos = transform.position.y;
        offset = transform.position - playerforRotation.transform.position;
    }

    // LateUpdate is called after Update each frame
    void FixedUpdate()
    {

        //transform.position = playerforRotation.transform.position + offset;
        // transform.position = new Vector3(playerforRotation.transform.position.x + offset.x, ypos, playerforRotation.transform.position.z + offset.z);

       // CameraRotate();
       // transform.LookAt(playerforRotation.transform.position);
      
       
    }

    void CameraRotate()
    {
        // float x = player.transform.position.x;
        hAxis = Input.GetAxis("Horizontal");
        vAxis = Input.GetAxis("Vertical");
        //  hAxis = playerforRotation.GetComponent<Rigidbody>().velocity.x* playerforRotation.GetComponent<Rigidbody>().velocity.z;
//if (playerforRotation.getComponent<CheckGrounded>().CheckGrounded() == true)
       // {
            if (hAxis > 0 || vAxis > 0)
            {

                // while(transform.rotation.y < 81) { 

                transform.RotateAround(player.transform.position, new Vector3(0.0f, 1.0f, 0.0f), (hAxis + vAxis) * Time.deltaTime * speedMod);
                Debug.Log(gameObject.transform.rotation.eulerAngles.y.ToString());


            }
            if (hAxis < 0 || vAxis < 0)
            {

                transform.RotateAround(player.transform.position, new Vector3(0.0f, 1.0f, 0.0f), (hAxis + vAxis) * Time.deltaTime * speedMod);
                Debug.Log(gameObject.transform.rotation.eulerAngles.y.ToString());




            }
        }
    }
//}
