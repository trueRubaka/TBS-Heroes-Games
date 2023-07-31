using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;



public class Selectable : MonoBehaviour
{

    public void Select()
    {

        GetComponent<Renderer>().material.color = Color.yellow;

    }

    public void Deselect()
    {

        if (gameObject.CompareTag("black"))
        {
            GetComponent<Renderer>().material.color = Color.black;
        }
        else if (gameObject.CompareTag("white"))
        {
            GetComponent<Renderer>().material.color = Color.white;
        }
        else if (gameObject.CompareTag("Player"))
        {
            GetComponent<Renderer>().material.color = Color.red;
        }
    }


}