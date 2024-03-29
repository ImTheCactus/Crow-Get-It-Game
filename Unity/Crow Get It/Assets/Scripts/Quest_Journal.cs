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
    public GameObject QueenieIcon;
    public GameObject WillowIcon;
    public GameObject BubblesIcon;
    public GameObject RaphIcon;
    public GameObject ScarecrowIcon;
    public GameObject ScarecrowIconHappy;
    public GameObject PeachIcon;
    public GameObject HoneyIcon;
    public GameObject FlowerIcon;
    public GameObject BerryIcon;
    public GameObject UrchinIcon;
    public GameObject FireflyIcon;
    public GameObject HayIcon;
    public GameObject ButtonIcon;
    public GameObject HatIcon;
    

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
    bool QueenieIconActive = false;
    bool WillowIconActive = false;
    bool BubblesIconActive = false;
    bool RaphIconActive = false;
    bool ScarecrowIconActive = false;
    bool ScarecrowIconHappyActive = false;
    bool PeachIconActive = false;
    bool HoneyIconActive = false;
    bool FlowerIconActive = false;
    bool BerryIconActive = false;
    bool UrchinIconActive = false;
    bool FireflyIconActive = false;
    bool HayIconActive = false;
    bool ButtonIconActive = false;
    bool HatIconActive = false;
    

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

        //NPC icons
        MushIcon.SetActive(false);
        ChipIcon.SetActive(false);
        QueenieIcon.SetActive(false);
        WillowIcon.SetActive(false);
        BubblesIcon.SetActive(false);
        RaphIcon.SetActive(false);
        ScarecrowIcon.SetActive(false);
        ScarecrowIconHappy.SetActive(false);

        //Item Icons
        PeachIcon.SetActive(false);
        HoneyIcon.SetActive(false);
        FlowerIcon.SetActive(false);
        BerryIcon.SetActive(false);
        UrchinIcon.SetActive(false);
        FireflyIcon.SetActive(false);
        HayIcon.SetActive(false);
        ButtonIcon.SetActive(false);
        HatIcon.SetActive(false);
       
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

        if  (customYarnCommands.QueenieIconActive == true)
        {
            QueenieIcon.SetActive(true);
        }
        else if (customYarnCommands.QueenieIconActive == false)
        {
            QueenieIcon.SetActive(false);
        }

        if  (customYarnCommands.WillowIconActive == true)
        {
            WillowIcon.SetActive(true);
        }
        else if (customYarnCommands.WillowIconActive == false)
        {
            WillowIcon.SetActive(false);
        }

        if  (customYarnCommands.BubblesIconActive == true)
        {
            BubblesIcon.SetActive(true);
        }
        else if (customYarnCommands.BubblesIconActive == false)
        {
            BubblesIcon.SetActive(false);
        }

        if  (customYarnCommands.RaphIconActive == true)
        {
            RaphIcon.SetActive(true);
        }
        else if (customYarnCommands.RaphIconActive == false)
        {
            RaphIcon.SetActive(false);
        }

        if  (customYarnCommands.ScarecrowIconActive == true)
        {
            ScarecrowIcon.SetActive(true);
        }
        else if (customYarnCommands.ScarecrowIconActive == false)
        {
            ScarecrowIcon.SetActive(false);
        }

        if  (customYarnCommands.ScarecrowIconHappyActive == true)
        {
            ScarecrowIconHappy.SetActive(true);
        }
        else if (customYarnCommands.ScarecrowIconHappyActive == false)
        {
            ScarecrowIconHappy.SetActive(false);
        }

        //This is Item Icon code
        if  (customYarnCommands.PeachIconActive == true)
        {
            PeachIcon.SetActive(true);
        }
        else if (customYarnCommands.PeachIconActive == false)
        {
            PeachIcon.SetActive(false);
        }

        if  (customYarnCommands.HoneyIconActive == true)
        {
            HoneyIcon.SetActive(true);
        }
        else if (customYarnCommands.HoneyIconActive == false)
        {
            HoneyIcon.SetActive(false);
        }

        if  (customYarnCommands.FlowerIconActive == true)
        {
            FlowerIcon.SetActive(true);
        }
        else if (customYarnCommands.FlowerIconActive == false)
        {
            FlowerIcon.SetActive(false);
        }

        if  (customYarnCommands.BerryIconActive == true)
        {
            BerryIcon.SetActive(true);
        }
        else if (customYarnCommands.BerryIconActive == false)
        {
            BerryIcon.SetActive(false);
        }

        if  (customYarnCommands.UrchinIconActive == true)
        {
            UrchinIcon.SetActive(true);
        }
        else if (customYarnCommands.UrchinIconActive == false)
        {
            UrchinIcon.SetActive(false);
        }

        if  (customYarnCommands.FireflyIconActive == true)
        {
            FireflyIcon.SetActive(true);
        }
        else if (customYarnCommands.FireflyIconActive == false)
        {
            FireflyIcon.SetActive(false);
        }

        if  (customYarnCommands.HayIconActive == true)
        {
            HayIcon.SetActive(true);
        }
        else if (customYarnCommands.HayIconActive == false)
        {
            HayIcon.SetActive(false);
        }

        if  (customYarnCommands.ButtonIconActive == true)
        {
            ButtonIcon.SetActive(true);
        }
        else if (customYarnCommands.ButtonIconActive == false)
        {
            ButtonIcon.SetActive(false);
        }

        if  (customYarnCommands.HatIconActive == true)
        {
            HatIcon.SetActive(true);
        }
        else if (customYarnCommands.HatIconActive == false)
        {
            HatIcon.SetActive(false);
        }
        
    }

}