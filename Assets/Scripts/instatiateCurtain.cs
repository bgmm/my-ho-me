using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instatiateCurtain : MonoBehaviour {

 
    public GameObject curtain;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

 

    public void spawncube()
    {

        Instantiate(curtain, (Camera.main.transform.position) + Camera.main.transform.forward, curtain.transform.rotation);

    }
}

