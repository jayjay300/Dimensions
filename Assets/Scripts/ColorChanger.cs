using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour {


    public Color altColor = Color.black;
    public Renderer rend;
    // Use this for initialization



    void NewColor()
    {
        altColor.g = 0f;
        altColor.r = 0f;
        altColor.b = 0f;
        altColor.a = 0f;
    }



    void Start () {


        NewColor();

        rend = GetComponent<Renderer>();

        rend.material.color = altColor;
    }
	
	// Update is called once per frame
	void Update () {
       altColor.g = Random.Range(0.0f, 1.0f);
       altColor.r = Random.Range(0.0f, 1.0f);
       altColor.b = Random.Range(0.0f, 1.0f);
       altColor.a = Random.Range(0.0f, 1.0f);
        Debug.Log(altColor.g);

        rend.material.color = altColor;
    }
}
