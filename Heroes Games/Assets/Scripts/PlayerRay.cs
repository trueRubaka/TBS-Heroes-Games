using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngineInternal;

public class PlayerRay : MonoBehaviour
{
    public Transform Pointer;
    public Selectable CurrentSelectable;

    void LateUpdate()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            Pointer.position = hit.point;


            Selectable selectable = hit.collider.gameObject.GetComponent<Selectable>();

            if (selectable)
            {
                if (CurrentSelectable && CurrentSelectable != selectable)
                {
                    CurrentSelectable.Deselect();

                }
                CurrentSelectable = selectable;
                selectable.Select();
            }
            else
            {
                if (CurrentSelectable)
                {
                    CurrentSelectable.Deselect();
                }
            }            
        }
    }
}
