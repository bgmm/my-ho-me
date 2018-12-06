using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllDeleteButtonsInactive: MonoBehaviour
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


    public void deactivateButtons()
    {
        foreach (GameObject shape in objects)
        {


            shape.transform.GetChild(0).gameObject.SetActive(false);
            Debug.Log("Sorry");

        }
    }

}

    

