using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterToInteract : MonoBehaviour
{
    private GameObject currentHitObject;
    public GameObject interactText;
    private bool inRange;

    public void Start()
    {
        interactText.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "InteractText")
        {
            inRange = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        inRange = false;
    }

    void FixedUpdate()
    {
        RaycastHit hit;
        int mask = 1 << LayerMask.NameToLayer("Interactable");

        if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, mask, QueryTriggerInteraction.Ignore)) //if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, mask, QueryTriggerInteraction.Ignore))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.red); //If collides with object, debug raycast is red.
            var selectedObject = hit.transform;

            if(selectedObject != null && inRange == true)
            {
                interactText.SetActive(true);
                currentHitObject = hit.transform.gameObject;
            }
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 8, Color.blue); //If collides with nothing, debug raycast is blue.

            if (currentHitObject != null)
            {
                interactText.SetActive(false);
                currentHitObject = null;
            }
        }
    }
}