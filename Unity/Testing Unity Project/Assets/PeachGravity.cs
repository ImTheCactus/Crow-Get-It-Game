using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeachGravity : MonoBehaviour
{
    public Rigidbody rB;
    private bool collision;
    public float sphereRadius = 5;

    private void Start()
    {
        rB = GetComponent<Rigidbody>();
        rB.isKinematic = true;
        Debug.Log("Kinematic set true");
    }

    private void ClickE()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            rB.isKinematic = false;
            Debug.Log("Kinematic set false");
        }
    }

    private void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "Player")
        {
            collision = true;
            Debug.Log("Player collision");
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawSphere(transform.position, sphereRadius);
    }

    private void Update()
    {
        if (Physics.CheckSphere(transform.position, sphereRadius));
        {
            Debug.Log("Something is here");
        }

        if (rB.isKinematic == false && collision == true)
        {
            Destroy(gameObject);
            Debug.Log("Peach destroyed");
            collision = false;
        }
    }
}
