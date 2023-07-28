using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EToInteract : MonoBehaviour
{
    public GameObject interactText;

    public void Start()
    {
        interactText.SetActive(false);
        Debug.Log("Mouse is off test capsule");
    }
    public void OnMouseOver()
    {
        interactText.SetActive(true);
        Debug.Log("Mouse is on test capsule");
    }

    public void OnMouseExit()
    {
        interactText.SetActive(false);
        Debug.Log("Mouse is off test capsule");
    }
}