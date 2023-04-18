using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpApple : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        Destroy(gameObject);
        Debug.Log("Picked up 'Ball'");
        //var InteractTestScript = GetComponent();
        //InteractTestScript.TalkToNPC++;
        //increase a int by 1
    }
}
