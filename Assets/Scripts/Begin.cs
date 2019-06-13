using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Begin : MonoBehaviour {

    private int counter = 0;
    public GameObject title,start,intro,spaceship,blackhole,quote;

	// Use this for initialization
	void Start () {
        title = GameObject.Find("TITLE");
        start = GameObject.Find("START");
        intro = GameObject.Find("INTRO");
		quote = GameObject.Find("QUOTE");
        spaceship = GameObject.Find("spaceship");
        blackhole = GameObject.Find("blackhole");
        intro.gameObject.SetActive(false);
        spaceship.gameObject.SetActive(false);
        blackhole.gameObject.SetActive(false);
		quote.gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("space"))
        {
            counter++;
        }
        if (counter == 1)
        {
			
			quote.gameObject.SetActive(true);
            start.gameObject.SetActive(false);
            title.gameObject.SetActive(false);
          

        }
		if (counter == 2) {
			quote.gameObject.SetActive(false);
			intro.gameObject.SetActive(true);
		}
        if (counter == 3)
        {
			intro.gameObject.SetActive(false);
            spaceship.gameObject.SetActive(true);
            blackhole.gameObject.SetActive(true);



        }
        if (counter == 4)
        {
            Debug.Log("test");
            SceneManager.LoadScene(1);
        }
    }
}
