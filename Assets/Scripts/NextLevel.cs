using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NextLevel : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D(Collider2D other) {
        if (other.transform.tag == "Player")
        {
            Debug.Log("test");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        
	}
}
