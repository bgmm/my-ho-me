using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instatiateCube : MonoBehaviour {

 
    public GameObject cube;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

 

    public void spawncube()
    {

        Instantiate(cube, (Camera.main.transform.position) + Camera.main.transform.forward, cube.transform.rotation);

    }
}

