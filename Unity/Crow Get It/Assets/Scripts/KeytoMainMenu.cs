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
            SceneManager.LoadScene("MainMenu");
            Debug.Log("da escapee were peeessed!");
        }
    }
}
