using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Outro : MonoBehaviour {
	GameObject spaceship,blackhole;
	private bool pressed=false;
	// Use this for initialization
	void Start () {
		spaceship = GameObject.Find("spaceship");
		blackhole = GameObject.Find("blackhole");
	}
	
	// Update is called once per frame
	void Update () {

		 
		if(Input.GetKeyDown("space")){
			pressed = true;
		}
			if(pressed == true){
			spaceship.transform.Translate (1, 0, 0,Space.World);
			spaceship.transform.Rotate (0,0,20,Space.Self);
			}
		if (spaceship.transform.position.x > 20) {
			SceneManager.LoadScene(0);
		}
	}
}
