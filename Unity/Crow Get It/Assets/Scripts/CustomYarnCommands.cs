using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class CustomYarnCommands : MonoBehaviour
{
public PlayerMovement playerMovement;
public bool Pcontroller = true;

public bool mushQuestActive = false;
public bool chipQuestActive = false;
public bool queenieQuestActive = false;
public bool bubblesQuestActive = false;
public bool raphQuestActive = false;
public bool willowQuestActive = false;
public bool scarecrowStrawQuestActive = false;
public bool scarecrowButtonQuestActive = false;
public bool scarecrowHatQuestActive = false;
public bool MushIconActive = false;
public bool ChipIconActive = false;
public bool QueenieIconActive = false;
public bool WillowIconActive = false;
public bool BubblesIconActive = false;
public bool RaphIconActive = false;
public bool ScarecrowIconActive = false;

//new stuff
public bool MExplenationSprite = true;
public bool CExplenationSprite = true;
public bool QExplenationSprite = true;
public bool WExplenationSprite = true;
public bool BExplenationSprite = true;
public bool RExplenationSprite = true;
public bool SExplenationSprite = true;
// sparkle
public bool PeachSpriteActive = false;
public bool HoneySpriteActive = false;
public bool FlowerSpriteActive = false;
public bool BerrySpriteActive = false;
public bool UrchinSpriteActive = false;
public bool FireflySpriteActive = false;
public DialogueRunner dialogueRunner;

 void Start()
 {
    //Custom Yarn commands           (Name for in yarn, function to run)
    // Name for in Yarn [CAN] be differant to the function name
    dialogueRunner.AddCommandHandler("PlayerFrezze", PlayerFrezze);

    dialogueRunner.AddCommandHandler("MushQuestSwitch", MushQuestSwitch);
    dialogueRunner.AddCommandHandler("ChipQuestSwitch", ChipQuestSwitch);
    dialogueRunner.AddCommandHandler("QueenieQuestSwitch", QueenieQuestSwitch);
    dialogueRunner.AddCommandHandler("BubblesQuestSwitch", BubblesQuestSwitch);
    dialogueRunner.AddCommandHandler("RaphQuestSwitch", RaphQuestSwitch);
    dialogueRunner.AddCommandHandler("WillowQuestSwitch", WillowQuestSwitch);
    dialogueRunner.AddCommandHandler("ScarecrowStrawSwitch", ScarecrowStrawSwitch);
    dialogueRunner.AddCommandHandler("ScarecrowButtonSwitch", ScarecrowButtonSwitch);
    dialogueRunner.AddCommandHandler("ScarecrowHatSwitch", ScarecrowHatSwitch);
    dialogueRunner.AddCommandHandler("MushIcon", MushIconSwitch);
    dialogueRunner.AddCommandHandler("ChipIcon", ChipIconSwitch);
    dialogueRunner.AddCommandHandler("QueenieIcon", QueenieIconSwitch);
    dialogueRunner.AddCommandHandler("WillowIcon", WillowIconSwitch);
    dialogueRunner.AddCommandHandler("BubblesIcon", BubblesIconSwitch);
    dialogueRunner.AddCommandHandler("RaphIcon", RaphIconSwitch);
    dialogueRunner.AddCommandHandler("ScarecrowIcon", ScarecrowIconSwitch);
      //new stuff
    dialogueRunner.AddCommandHandler("MExplenationSprite", MExplenationSpriteSwitch);
    dialogueRunner.AddCommandHandler("CExplenationSprite", CExplenationSpriteSwitch);
    dialogueRunner.AddCommandHandler("QExplenationSprite", QExplenationSpriteSwitch);
    dialogueRunner.AddCommandHandler("WExplenationSprite", WExplenationSpriteSwitch);
    dialogueRunner.AddCommandHandler("BExplenationSprite", BExplenationSpriteSwitch);
    dialogueRunner.AddCommandHandler("RExplenationSprite", RExplenationSpriteSwitch);
    dialogueRunner.AddCommandHandler("SExplenationSprite", SExplenationSpriteSwitch);
    //sparkles
    dialogueRunner.AddCommandHandler("PSparkle", PeachSPARSwitch);
    dialogueRunner.AddCommandHandler("HSparkle", HoneySPARSwitch);
    dialogueRunner.AddCommandHandler("FloSparkle", FlowerSPARSwitch);
    dialogueRunner.AddCommandHandler("BSparkle", BerrySPARSwitch);
    dialogueRunner.AddCommandHandler("USparkle", UrchinSPARSwitch);
    dialogueRunner.AddCommandHandler("FirSparkle", FireflySPARSwitch);
    
 }

    public void MushQuestSwitch()
    {
        if (mushQuestActive == false)
        {
            mushQuestActive = true;
            Debug.Log("quest switch mush");
        }
        else
        {
            mushQuestActive = false;
        }

    }


    public void ChipQuestSwitch()
    {
        if (chipQuestActive == false)
        {
           chipQuestActive = true;
            Debug.Log("quest switch chip");
        }
        else
        {
            chipQuestActive = false;
        }
    }

     public void QueenieQuestSwitch()
    {
        if (queenieQuestActive == false)
        {
           queenieQuestActive = true;
            Debug.Log("quest switch queenie");
        }
        else
        {
            queenieQuestActive = false;
        }
    }


     public void BubblesQuestSwitch()
    {
        if (bubblesQuestActive == false)
        {
           bubblesQuestActive  = true;
            Debug.Log("quest switch queenie");
        }
        else
        {
            bubblesQuestActive  = false;
        }
    }


      public void RaphQuestSwitch()
    {
        if (raphQuestActive == false)
        {
           raphQuestActive  = true;
            Debug.Log("quest switch raph");
        }
        else
        {
            raphQuestActive  = false;
        }
    }


        public void WillowQuestSwitch()
    {
        if (willowQuestActive == false)
        {
           willowQuestActive  = true;
            Debug.Log("quest switch willow");
        }
        else
        {
            willowQuestActive  = false;
        }
    }
    
     public void ScarecrowStrawSwitch()
    {
        if (scarecrowStrawQuestActive == false)
        {
           scarecrowStrawQuestActive  = true;
            Debug.Log("quest switch scarecrow");
        }
        else
        {
            scarecrowStrawQuestActive  = false;
        }
    }


 public void ScarecrowButtonSwitch()
    {
        if (scarecrowButtonQuestActive == false)
        {
           scarecrowButtonQuestActive  = true;
            Debug.Log("quest switch scarecrow");
        }
        else
        {
            scarecrowButtonQuestActive  = false;
        }
    }


     public void ScarecrowHatSwitch()
    {
        if (scarecrowHatQuestActive == false)
        {
           scarecrowHatQuestActive  = true;
            Debug.Log("quest switch scarecrow");
        }
        else
        {
            scarecrowHatQuestActive  = false;
        }
    }
    
        public void MushIconSwitch()
    {
        if (MushIconActive == false)
        {
            MushIconActive = true;
            Debug.Log("quest switch mush");
        }
        else
        {
            MushIconActive = false;
        }

    }

        public void ChipIconSwitch()
    {
        if (ChipIconActive == false)
        {
            ChipIconActive = true;
            Debug.Log("quest switch chip");
        }
        else
        {
            ChipIconActive = false;
        }

    }    

            public void QueenieIconSwitch()
    {
        if (QueenieIconActive == false)
        {
            QueenieIconActive = true;
            Debug.Log("quest switch queenie");
        }
        else
        {
            QueenieIconActive = false;
        }

    }  
            public void WillowIconSwitch()
    {
        if (WillowIconActive == false)
        {
            WillowIconActive = true;
            Debug.Log("quest switch Willow");
        }
        else
        {
            WillowIconActive = false;
        }

    }  

            public void BubblesIconSwitch()
    {
        if (BubblesIconActive == false)
        {
            BubblesIconActive = true;
            Debug.Log("quest switch Bubbles");
        }
        else
        {
            BubblesIconActive = false;
        }

    } 

            public void RaphIconSwitch()
    {
        if (RaphIconActive == false)
        {
            RaphIconActive = true;
            Debug.Log("quest switch Raph");
        }
        else
        {
            RaphIconActive = false;
        }

    }  

            public void ScarecrowIconSwitch()
    {
        if (ScarecrowIconActive == false)
        {
            ScarecrowIconActive = true;
            Debug.Log("quest switch Scarecrow");
        }
        else
        {
            ScarecrowIconActive = false;
        }

    }   


     //new stuff
    public void MExplenationSpriteSwitch()
    {
        if (MExplenationSprite == false)
        {
           MExplenationSprite  = true;
            Debug.Log("ExplenationSprite");
        }
        else
        {
            MExplenationSprite  = false;
        }
        
        
    }

       public void CExplenationSpriteSwitch()
    {
        if (CExplenationSprite == false)
        {
           CExplenationSprite  = true;
            Debug.Log("ExplenationSprite");
        }
        else
        {
            CExplenationSprite  = false;
        }
        
        
    }


    public void QExplenationSpriteSwitch()
    {
        if (QExplenationSprite == false)
        {
           QExplenationSprite  = true;
            Debug.Log("ExplenationSprite");
        }
        else
        {
            QExplenationSprite  = false;
        }
        
        
    }


        public void WExplenationSpriteSwitch()
    {
        if (WExplenationSprite == false)
        {
           WExplenationSprite  = true;
            Debug.Log("ExplenationSprite");
        }
        else
        {
            WExplenationSprite  = false;
        }
        
        
    }


        public void BExplenationSpriteSwitch()
    {
        if (BExplenationSprite == false)
        {
           BExplenationSprite  = true;
            Debug.Log("ExplenationSprite");
        }
        else
        {
            BExplenationSprite  = false;
        }
        
        
    }


        public void RExplenationSpriteSwitch()
    {
        if (RExplenationSprite == false)
        {
           RExplenationSprite  = true;
            Debug.Log("ExplenationSprite");
        }
        else
        {
            RExplenationSprite  = false;
        }
        
        
    }


        public void SExplenationSpriteSwitch()
    {
        if (SExplenationSprite == false)
        {
           SExplenationSprite  = true;
            Debug.Log("ExplenationSprite");
        }
        else
        {
            SExplenationSprite  = false;
        }
        
        
    }

  //Sparkles
    public void PeachSPARSwitch()
    {
        if (PeachSpriteActive == false)
        {
           PeachSpriteActive  = true;
            Debug.Log("Peachglitter");
        }
        else
        {
            PeachSpriteActive  = false;
        }
    }


        public void HoneySPARSwitch()
    {
        if (HoneySpriteActive == false)
        {
           HoneySpriteActive  = true;
            Debug.Log("honeyglitter");
        }
        else
        {
            HoneySpriteActive  = false;
        }
    }

        public void FlowerSPARSwitch()
    {
        if (FlowerSpriteActive == false)
        {
           FlowerSpriteActive  = true;
            Debug.Log("flowerglitter");
        }
        else
        {
            FlowerSpriteActive  = false;
        }
    }


        public void BerrySPARSwitch()
    {
        if (BerrySpriteActive == false)
        {
           BerrySpriteActive  = true;
            Debug.Log("berryglitter");
        }
        else
        {
            BerrySpriteActive  = false;
        }
    }


        public void UrchinSPARSwitch()
    {
        if (UrchinSpriteActive == false)
        {
           UrchinSpriteActive  = true;
            Debug.Log("urchinglitter");
        }
        else
        {
            UrchinSpriteActive  = false;
        }
    }


        public void FireflySPARSwitch()
    {
        if (FireflySpriteActive == false)
        {
           FireflySpriteActive  = true;
            Debug.Log("Fireflyglitter");
        }
        else
        {
            FireflySpriteActive  = false;
        }
    }

         public void PlayerFrezze()
    {
        if (playerMovement.inDialogue == false)
        {
           playerMovement.inDialogue  = true;
            Debug.Log("Frezze");
        }
        else
        {
            playerMovement.inDialogue  = false;
        }
    }


}