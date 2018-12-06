using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instatiatePlace : MonoBehaviour {

 
    public GameObject place;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

 

    public void spawnplace()
    {

        Instantiate(place, (Camera.main.transform.position*2f) + Camera.main.transform.forward, place.transform.rotation);

    }
}

