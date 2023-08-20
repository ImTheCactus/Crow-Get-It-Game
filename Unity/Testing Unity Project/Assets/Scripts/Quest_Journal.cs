using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine;
using System.Collections;

public class Quest_Journal : MonoBehaviour
{
    //public string key;
    public GameObject tabMenu;

    private bool isOpen;

    void Start()
    {
        isOpen = false;
    }

    public void Update()
    {
        if (Input.GetKeyDown("tab"))
        {
            if (isOpen == false)
            {
                tabMenu.SetActive(true);
                isOpen = true;

            }
            else
            {
                tabMenu.SetActive(false);
                isOpen = false;
            }
            //EventSystem.current.SetSelectedGameObject(this.gameObject);
        }

    } 
    
}