using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TogglePause : MonoBehaviour
{
    public Canvas PauseCanvas;
    private bool PauseActive = false;

    void update () 
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            PauseActive = !PauseActive;
            //PauseCanvas.transform.SetActive(PauseActive);
        }
    }
}
