using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particleActivate : MonoBehaviour {

    public ParticleSystem rain;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ToggleParticle()
    {
      if (rain.isPlaying)
        {
            rain.Stop();

        }

      else
        {
            rain.Play();
        }
    }
}
