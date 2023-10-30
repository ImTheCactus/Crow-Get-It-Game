using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine;
using System.Collections;

public class QuestSpritesActivation : MonoBehaviour
{
    public GameObject MushExplenationSprite;
    public GameObject ChipExplenationSprite;
    public GameObject QueenieExplenationSprite;
    public GameObject WillowExplenationSprite;
    public GameObject BubblesExplenationSprite;
    public GameObject RaphExplenationSprite;
    public GameObject ScareExplenationSprite;
    //sparkles

     public GameObject PeachSprite;
     public GameObject HoneySprite;
     public GameObject FlowerSprite;
     public GameObject BerrySprite;
     public GameObject UrchinSprite;
     public GameObject FireflySprite;
     public GameObject player;

    public CustomYarnCommands customYarnCommands;

    CharacterController controller;

    
    bool MExplenationSprite = true;
    bool CExplenationSprite = true;
    bool QExplenationSprite = true;
    bool WExplenationSprite = true;
    bool BExplenationSprite = true;
    bool RExplenationSprite = true;
    bool SExplenationSprite = true;
    //sparkles
    bool PeachSpriteActive = false;
    bool HoneySpriteSpriteActive = false;
    bool FlowerSpriteActive = false;
    bool BerrySpriteActive = false;
    bool UrchinSpriteActive = false;
    bool FireflySpriteActive = false;
    // Start is called before the first frame update
    void Start()
    {
       MushExplenationSprite.SetActive(true);
       ChipExplenationSprite.SetActive(true);
       QueenieExplenationSprite.SetActive(true);
       WillowExplenationSprite.SetActive(true);
       BubblesExplenationSprite.SetActive(true);
       RaphExplenationSprite.SetActive(true);
       ScareExplenationSprite.SetActive(true);
       
       //Sprites
       PeachSprite.SetActive(false);
       HoneySprite.SetActive(false);
       FlowerSprite.SetActive(false);
       BerrySprite.SetActive(false);
       UrchinSprite.SetActive(false);
       FireflySprite.SetActive(false);

    }
 // Update is called once per frame
    public void Update()
    {
        SpriteCheck ();
    }
   
    public void SpriteCheck ()
    {
        if (customYarnCommands.MExplenationSprite == true)
        {
            MushExplenationSprite.SetActive(true);
        }
        else if (customYarnCommands.MExplenationSprite == false)
        {
            MushExplenationSprite.SetActive(false);
        }


        if (customYarnCommands.CExplenationSprite == true)
        {
            ChipExplenationSprite.SetActive(true);
        }
        else if (customYarnCommands.CExplenationSprite == false)
        {
            ChipExplenationSprite.SetActive(false);
        }


        if (customYarnCommands.QExplenationSprite == true)
        {
            QueenieExplenationSprite.SetActive(true);
        }
        else if (customYarnCommands.QExplenationSprite == false)
        {
            QueenieExplenationSprite.SetActive(false);
        }


        if (customYarnCommands.WExplenationSprite == true)
        {
            WillowExplenationSprite.SetActive(true);
        }
        else if (customYarnCommands.WExplenationSprite == false)
        {
            WillowExplenationSprite.SetActive(false);
        }


        if (customYarnCommands.BExplenationSprite == true)
        {
            BubblesExplenationSprite.SetActive(true);
        }
        else if (customYarnCommands.BExplenationSprite == false)
        {
            BubblesExplenationSprite.SetActive(false);
        }

        if (customYarnCommands.RExplenationSprite == true)
        {
            RaphExplenationSprite.SetActive(true);
        }
        else if (customYarnCommands.RExplenationSprite == false)
        {
            RaphExplenationSprite.SetActive(false);
        }

        if (customYarnCommands.SExplenationSprite == true)
        {
            ScareExplenationSprite.SetActive(true);
        }
        else if (customYarnCommands.SExplenationSprite == false)
        {
            ScareExplenationSprite.SetActive(false);
        }
        //Sparkles
        
        if (customYarnCommands.PeachSpriteActive == true)
        {
           PeachSprite.SetActive(true);
        }
        else if (customYarnCommands. HoneySpriteActive == false)
        {
           PeachSprite.SetActive(false);
        }



        if (customYarnCommands. HoneySpriteActive == true)
        {
            HoneySprite.SetActive(true);
        }
        else if (customYarnCommands. HoneySpriteActive == false)
        {
            HoneySprite.SetActive(false);
        }


        if (customYarnCommands. FlowerSpriteActive == true)
        {
             FlowerSprite.SetActive(true);
        }
        else if (customYarnCommands. FlowerSpriteActive == false)
        {
             FlowerSprite.SetActive(false);
        }


        if (customYarnCommands.BerrySpriteActive == true)
        {
            BerrySprite.SetActive(true);
        }
        else if (customYarnCommands.BerrySpriteActive == false)
        {
            BerrySprite.SetActive(false);
        }


        if (customYarnCommands. UrchinSpriteActive == true)
        {
             UrchinSprite.SetActive(true);
        }
        else if (customYarnCommands. UrchinSpriteActive == false)
        {
             UrchinSprite.SetActive(false);
        }


        if (customYarnCommands.FireflySpriteActive == true)
        {
            FireflySprite.SetActive(true);
        }
        else if (customYarnCommands.FireflySpriteActive == false)
        {
            FireflySprite.SetActive(false);
        }

    }
}
