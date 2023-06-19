using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;



public class Selectable : MonoBehaviour
{
    public Material boardBlack;
    public Material boardWhite;
    
    private Material previousMaterial;

    public void Select()
    {
        previousMaterial = GetComponent<Renderer>().material;
        GetComponent<Renderer>().material.color = Color.yellow;
    }

    public void Deselect()
    {
        if (previousMaterial != null)
        {
            GetComponent<Renderer>().material = previousMaterial;
            previousMaterial = null;
        }
        else
        {
            if (gameObject.CompareTag("black"))
            {
                GetComponent<Renderer>().material = boardBlack;
            }
            else if (gameObject.CompareTag("white"))
            {
                GetComponent<Renderer>().material = boardWhite;
            }
        }
    }
}