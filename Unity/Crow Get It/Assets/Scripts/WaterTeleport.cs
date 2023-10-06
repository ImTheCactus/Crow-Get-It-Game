using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterTeleport : MonoBehaviour
{

    public GameObject teleportPoint;
    public GameObject player;

    Vector3 teleportPos;
    CharacterController controller;

    void Start()
    {
        teleportPos = teleportPoint.transform.position;
        controller = player.GetComponent<CharacterController>();
        controller.enabled = true;

    }
    void OnTriggerEnter (Collider other)
    {
        if(other.gameObject.tag == "Respawn")
        {
            controller.enabled = false;
            player.transform.position = teleportPos;
            controller.enabled = true;
            //Debug.Log("YOU CAN'T SWIM");
        }
    }
}
