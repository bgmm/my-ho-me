using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation01 : MonoBehaviour {
public AudioSource audioSource;
public Animation animation2;
    public GameObject object1;

    public AudioClip audioClip;
    public String animationTrigger;

  
    private Animator animator;

    void Start()
    {
        // make sure that we have an AudioSource - do this here once instead of every frame
        if (audioSource == null)
        { // if AudioSource is missing
            Debug.LogWarning("AudioSource component missing from this gameobject. Adding one.");
            // let's just add the AudioSource component dynamically
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        // make sure that object1 is a valid GameObject and has an animation - do this here once instead of every frame
        if ((object1 != null) && (object1.GetComponent<Animator>() != null))
        {
            animator = object1.GetComponent<Animator>();
        }
    }

    void Update()
    {
        if ((Input.GetMouseButtonDown(0)))
        {
            if ((animator != null) && (animationTrigger != ""))
                animator.SetTrigger(animationTrigger);
            audioSource.PlayOneShot(audioClip);
        }
    }


  
}
