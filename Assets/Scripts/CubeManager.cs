using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeManager : MonoBehaviour
{

   
    public GameObject cubePrefab;
    UnityEngine.XR.WSA.Input.GestureRecognizer recognizer;


    // Use this for initialization
    void Start () {
        recognizer = new UnityEngine.XR.WSA.Input.GestureRecognizer();

        recognizer.TappedEvent += Recognizer_TappedEvent;

        recognizer.StartCapturingGestures();

    }

    private void Recognizer_TappedEvent(UnityEngine.XR.WSA.Input.InteractionSourceKind source, int tapCount, Ray headRay)
    {
        var direction = headRay.direction;

        var origin = headRay.origin;

        var position = origin + direction * 2.0f;

        Instantiate(cubePrefab, position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
