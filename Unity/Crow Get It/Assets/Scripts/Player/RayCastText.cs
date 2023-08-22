using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastText : MonoBehaviour
{
    public GameObject currentHitObject;
    public GameObject interactText;

    public void Start()
    {
        interactText.SetActive(false);
        //Debug.Log("Text Hidden");
    }

    void FixedUpdate()
    {
        RaycastHit hit;
        int mask = 1 << LayerMask.NameToLayer("Interactable");

        if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, mask)) //BACKUP:if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.red); //If collides with object, debug raycast is red.
            var selectedObject = hit.transform;

            if(selectedObject != null)
            {
                interactText.SetActive(true);
                //Debug.Log("Text Shown");
                currentHitObject = hit.transform.gameObject;
            }
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 8, Color.blue); //If collides with nothing, debug raycast is blue.

            if (currentHitObject != null)
            {
                interactText.SetActive(false);
                //Debug.Log("Text Hidden");
                currentHitObject = null;
            }
        }
    }
}
