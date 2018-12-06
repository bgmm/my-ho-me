using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllDeleteButtons : MonoBehaviour
{


    public GameObject[] objects;


    void Start()
    {
        objects = GameObject.FindGameObjectsWithTag("objects");
    }
   


    void Update()
    {

        objects = GameObject.FindGameObjectsWithTag("objects");
        

    }

                                                          
    public void activateButtons()
    {
        foreach (GameObject shape in objects)
        {

            shape.transform.GetChild(0).gameObject.SetActive(true);
            Debug.Log("Sorry");

        }
    }

}

    

