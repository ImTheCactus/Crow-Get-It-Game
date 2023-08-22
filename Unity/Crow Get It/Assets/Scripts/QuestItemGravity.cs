using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestItemGravity : MonoBehaviour
{
    public Rigidbody rB;
    private bool collision;

    private void Start()
    {
        rB = GetComponent<Rigidbody>();
        rB.isKinematic = true;
        //Debug.Log("Kinematic set true");
    }

    private void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(0))
        {
            rB.isKinematic = false;
            //Debug.Log("Kinematic set false");
        }
    }

    private void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "Player")
        {
            collision = true;
            //Debug.Log("Player collision");
        }
    }

    private void Update()
    {
        if (rB.isKinematic == false && collision == true)
        {
            Destroy(gameObject);
            //Debug.Log("Peach destroyed");
            collision = false;
        }
    }
}
