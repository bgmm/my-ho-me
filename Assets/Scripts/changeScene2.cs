using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene1 : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OtherScene()
    {
        SceneManager.LoadScene("experiment");
        Debug.Log("scene changed");
        
    }

}