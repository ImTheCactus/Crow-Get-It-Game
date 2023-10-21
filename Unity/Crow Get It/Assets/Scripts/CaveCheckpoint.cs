using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaveCheckpoint : MonoBehaviour
{
    public GameObject player;
    public CharacterController controller;
    public GameObject caveCheckpointPosition;
    private Vector3 restartPosition;
    private bool isRestarting;

    void Start()
    {
        restartPosition = caveCheckpointPosition.transform.position;
        controller.enabled = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        isRestarting = true;
    }

    private void OnTriggerExit(Collider other)
    {
        isRestarting = false;
    }

    private void RestartPlayerPosition()
    {
        if(isRestarting == true)
        {
            controller.enabled = false;
            player.transform.position = restartPosition;
            isRestarting = false;
            controller.enabled = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        RestartPlayerPosition();
    }
}