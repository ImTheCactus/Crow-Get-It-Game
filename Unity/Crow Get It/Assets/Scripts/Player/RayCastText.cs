using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastText : MonoBehaviour
{
    public GameObject currentHitObject;
    public GameObject interactText;
    private bool inRange;

    public void Start()
    {
        interactText.SetActive(false);
    }

    /*
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Trigger active");
        if (other.attachedRigidbody.tag == "TEST")
        {
            inRange = true;
            Debug.Log("inRange = true");
        }
        else
        {
            inRange = false;
            Debug.Log("inRange = false");
        }
    }
    */

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger active");
        if (other.attachedRigidbody.tag == "TEST")
        {
            inRange = true;
            Debug.Log("inRange = true");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        inRange = false;
        Debug.Log("inRange = false");
    }

    void FixedUpdate()
    {
        RaycastHit hit;
        int mask = 1 << LayerMask.NameToLayer("Interactable");

        if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, mask, QueryTriggerInteraction.Ignore)) //if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, mask, QueryTriggerInteraction.Ignore))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.red); //If collides with object, debug raycast is red.
            var selectedObject = hit.transform;

            if(selectedObject != null && inRange == true) //&& ... = true
            {
                interactText.SetActive(true);
                Debug.Log("Text Shown");
                currentHitObject = hit.transform.gameObject;
            }
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 8, Color.blue); //If collides with nothing, debug raycast is blue.

            if (currentHitObject != null && inRange == false)
            {
                interactText.SetActive(false);
                Debug.Log("Text Hidden");
                currentHitObject = null;
            }
        }
    }
}