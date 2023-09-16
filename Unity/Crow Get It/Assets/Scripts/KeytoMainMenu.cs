using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class KeytoMainMenu : MonoBehaviour
{

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.F12))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            SceneManager.LoadScene("MainMenu");
            Debug.Log("da escapee were peeessed!");
        }
    }
}
