using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RotateD6 : MonoBehaviour {
    GameObject pivot;
    public int speed;
	// Use this for initialization
	void Start () {
        pivot = GameObject.Find("Audio");
    }
	
	// Update is called once per frame
	void Update () {
        if (SceneManager.GetActiveScene().name.ToString() == "D8")
        {
            transform.RotateAround(pivot.transform.position, new Vector3(0.0f, 1.0f, 0.0f), Time.deltaTime * speed);

        }
        else
        {
            transform.RotateAround(pivot.transform.position, new Vector3(1.0f, 0.0f, 0.0f), Time.deltaTime * speed);
        }
        }

}
