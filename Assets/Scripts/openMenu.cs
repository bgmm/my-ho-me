using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class openMenu : MonoBehaviour {

	// Use this for initialization
	private void Start () {
        InputManager.Instance.PushFallbackInputHandler(gameObject);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public virtual void OnInputClicked(InputClickedEventData eventData)
    {
        //DoStuff
        Debug.Log("Click !");
    }

}