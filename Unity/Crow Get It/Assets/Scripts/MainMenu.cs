using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    void Start()
    {
        Cursor.visible = true;
    }
    // Start is called before the first frame update
    public void PlayGame ()
    {
        SceneManager.LoadScene("GameScene");
        Cursor.visible = false;
    }

    public void QuitGame ()
    {
        Application.Quit();
    }
    public void GoMenu ()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
