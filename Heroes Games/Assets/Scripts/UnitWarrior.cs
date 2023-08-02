using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using TMPro;
using UnityEditor;
using UnityEngine;

public class UnitWarrior : MonoBehaviour
{
    public float speed;
    [SerializeField] private Vector3 target;
    private bool isMoving = false;

    private void LateUpdate()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                target = hit.transform.localPosition;
                isMoving = true;
                Debug.Log(target);

            }
        }
        if (isMoving == true)
        {
            if (!Mathf.Approximately(transform.position.magnitude, target.magnitude))
            {               
                transform.position = Vector3.Lerp(transform.position, target, 1 / (speed * (Vector3.Distance(transform.position, target))));
            }           
        }    
    }
}
