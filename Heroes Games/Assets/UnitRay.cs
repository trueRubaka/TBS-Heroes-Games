using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitRay : MonoBehaviour
{    
    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        Debug.DrawRay(transform.position, transform.forward * 100, Color.yellow);

        if (Physics.Raycast(ray))
        {
            Debug.Log("Hit smth");
        }
    }
}
