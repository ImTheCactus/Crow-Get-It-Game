using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarnDoorR : MonoBehaviour
{
    public float rotationAmount = 90f;
    private bool isOpen;

    private void Awake()
    {
        isOpen = false;
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (isOpen == false)
            {
                transform.Rotate(0, rotationAmount, 0);
                isOpen = true;
                //Debug.Log("Door Open");
            }

            else if (isOpen == true)
            {
                transform.Rotate(0, -rotationAmount, 0);
                isOpen = false;
                //Debug.Log("Door Closed");
            }
        }
    }
}
