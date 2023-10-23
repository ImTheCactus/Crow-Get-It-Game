using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine;
using System.Collections;

public class Quest_Journal : MonoBehaviour
{
    //public string key;
    public GameObject tabMenu;
    //public GameObject menuButton;
    public GameObject MushQuest;
    public GameObject ChipQuest;
    public GameObject QueenieQuest;
    public GameObject BubblesQuest;
    public GameObject RaphQuest;
    public GameObject WillowQuest;
    public GameObject ScarecrowStrawQuest;
    public GameObject ScarecrowButtonQuest;
    public GameObject ScarecrowHatQuest;
    public GameObject MushIcon;
    public GameObject ChipIcon;

    public CustomYarnCommands customYarnCommands;

    bool mushQuestActive = false;
    bool chipQuestActive = false;
    bool queenieQuestActive = false;
    bool bubblesQuestActive = false;
    bool raphQuestActive = false;
    bool willowQuestActive = false;
    bool scarecrowStrawQuestActive = false;
    bool scarecrowButtonQuestActive = false;
    bool scarecrowHatQuestActive = false;
    bool MushIconActive = false;
    bool ChipIconActive = false;

    private bool isOpen;

    void Start()
    {
        isOpen = false;
        Cursor.visible = false;
        MushQuest.SetActive(false);
        ChipQuest.SetActive(false);
        QueenieQuest.SetActive(false);
        BubblesQuest.SetActive(false);
        RaphQuest.SetActive(false);
        WillowQuest.SetActive(false); 
        ScarecrowStrawQuest.SetActive(false);
        ScarecrowButtonQuest.SetActive(false);
        ScarecrowHatQuest.SetActive(false);
        MushIcon.SetActive(false);
        ChipIcon.SetActive(false);
       
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (isOpen == false)
            {
                tabMenu.SetActive(true);

                //menuButton.SetActive(false);
                isOpen = true;
                //Cursor.lockState = CursorLockMode.None;
                //Cursor.visible = true;

            }
            else
            {
                tabMenu.SetActive(false);
                //menuButton.SetActive(true);
                isOpen = false;
                //Cursor.visible = false;
            }
            //EventSystem.current.SetSelectedGameObject(this.gameObject);
        }

        QuestsCheck();

    } 
    
    public void QuestsCheck()
    {
        
        if (customYarnCommands.mushQuestActive == true)
        {
            MushQuest.SetActive(true);
        }
        else if (customYarnCommands.mushQuestActive == false)
        {
            MushQuest.SetActive(false);
        }

        if (customYarnCommands.chipQuestActive == true)
        {
            ChipQuest.SetActive(true);
        }
        else if (customYarnCommands.chipQuestActive == false)
        {
            ChipQuest.SetActive(false);
        }


         if (customYarnCommands.queenieQuestActive == true)
        {
            QueenieQuest.SetActive(true);
        }
        else if (customYarnCommands.queenieQuestActive == false)
        {
            QueenieQuest.SetActive(false);
        }


         if (customYarnCommands.bubblesQuestActive == true)
        {
            BubblesQuest.SetActive(true);
        }
        else if (customYarnCommands.bubblesQuestActive == false)
        {
            BubblesQuest.SetActive(false);
        }

          if (customYarnCommands.raphQuestActive == true)
        {
             RaphQuest.SetActive(true);
        }
        else if (customYarnCommands.raphQuestActive == false)
        {
             RaphQuest.SetActive(false);
        }


         if (customYarnCommands.willowQuestActive == true)
        {
             WillowQuest.SetActive(true);
        }
        else if (customYarnCommands.willowQuestActive == false)
        {
             WillowQuest.SetActive(false);
        }


         if (customYarnCommands.scarecrowStrawQuestActive == true)
        {
             ScarecrowStrawQuest.SetActive(true);
        }
        else if (customYarnCommands.scarecrowStrawQuestActive == false)
        {
             ScarecrowStrawQuest.SetActive(false);
        }


          if (customYarnCommands.scarecrowButtonQuestActive == true)
        {
             ScarecrowButtonQuest.SetActive(true);
        }
        else if (customYarnCommands.scarecrowButtonQuestActive == false)
        {
             ScarecrowButtonQuest.SetActive(false);
        }


            if (customYarnCommands.scarecrowHatQuestActive == true)
        {
             ScarecrowHatQuest.SetActive(true);
        }
        else if (customYarnCommands.scarecrowHatQuestActive == false)
        {
             ScarecrowHatQuest.SetActive(false);
        }

        //This is icon code!

        if (customYarnCommands.MushIconActive == true)
        {
            MushIcon.SetActive(true);
        }
        else if (customYarnCommands.MushIconActive == false)
        {
            MushIcon.SetActive(false);
        }

        if  (customYarnCommands.ChipIconActive == true)
        {
            ChipIcon.SetActive(true);
        }
        else if (customYarnCommands.ChipIconActive == false)
        {
            ChipIcon.SetActive(false);
        }

    }

}