using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class CustomYarnCommands : MonoBehaviour
{
    public PlayerMovement playerMovement;
    public DialogueRunner dialogueRunner;
    private bool Pcontroller = true;

    //NPC quest variables:
    [Header("NPC quest activity")]
    public bool mushQuestActive = false;
    public bool chipQuestActive = false;
    public bool queenieQuestActive = false;
    public bool bubblesQuestActive = false;
    public bool raphQuestActive = false;
    public bool willowQuestActive = false;
    public bool scarecrowStrawQuestActive = false;
    public bool scarecrowButtonQuestActive = false;
    public bool scarecrowHatQuestActive = false;

    //NPC dialogue image variables:
    [Header("NPC dialogue image")]
    public bool MushIconActive = false;
    public bool ChipIconActive = false;
    public bool QueenieIconActive = false;
    public bool WillowIconActive = false;
    public bool BubblesIconActive = false;
    public bool RaphIconActive = false;
    public bool ScarecrowIconActive = false;

    //Quest items visibility variables:
    [Header("Quest item mesh visibility")]
    public bool PeachVisible = true;
    public bool HoneyVisible = true;
    public bool BerryVisible = true;
    public bool FlowerVisible = true;
    public bool UrchinVisible = true;
    public bool FireflyVisible = true;
    public bool ButtonEyesVisible = true;
    public bool HatVisible = true;

    //NPCs variables:
    [Header("Exclamation sprite")]
    public bool MExplenationSprite = true; //Mush.
    public bool CExplenationSprite = true; //Choc Chip.
    public bool QExplenationSprite = true; //Queenie.
    public bool WExplenationSprite = true; //Willow.
    public bool BExplenationSprite = true; //Bubbles.
    public bool RExplenationSprite = true; //Raph.
    public bool SExplenationSprite = true; //Scarecrow.
    
    //Quest items variables:
    [Header("Sparkle sprite")]
    public bool PeachSpriteActive = false;
    public bool HoneySpriteActive = false;
    public bool FlowerSpriteActive = false;
    public bool BerrySpriteActive = false;
    public bool UrchinSpriteActive = false;
    public bool FireflySpriteActive = false;

    //Start is called before the first frame update.
    public void Start()
    {
        //Example: dialogueRunner.AddCommandHandler("NameUsedInYarnSpinnerFile", NameOfRelevantClass);
        
        //Player position freeze during dialogue.
        dialogueRunner.AddCommandHandler("PlayerFrezze", PlayerFrezze);

        //NPC quest activity:
        dialogueRunner.AddCommandHandler("MushQuestSwitch", MushQuestSwitch);
        dialogueRunner.AddCommandHandler("ChipQuestSwitch", ChipQuestSwitch);
        dialogueRunner.AddCommandHandler("QueenieQuestSwitch", QueenieQuestSwitch);
        dialogueRunner.AddCommandHandler("BubblesQuestSwitch", BubblesQuestSwitch);
        dialogueRunner.AddCommandHandler("RaphQuestSwitch", RaphQuestSwitch);
        dialogueRunner.AddCommandHandler("WillowQuestSwitch", WillowQuestSwitch);
        dialogueRunner.AddCommandHandler("ScarecrowStrawSwitch", ScarecrowStrawSwitch);
        dialogueRunner.AddCommandHandler("ScarecrowButtonSwitch", ScarecrowButtonSwitch);
        dialogueRunner.AddCommandHandler("ScarecrowHatSwitch", ScarecrowHatSwitch);

        //NPCs dialogue image:
        dialogueRunner.AddCommandHandler("MushIcon", MushIconSwitch);
        dialogueRunner.AddCommandHandler("ChipIcon", ChipIconSwitch);
        dialogueRunner.AddCommandHandler("QueenieIcon", QueenieIconSwitch);
        dialogueRunner.AddCommandHandler("WillowIcon", WillowIconSwitch);
        dialogueRunner.AddCommandHandler("BubblesIcon", BubblesIconSwitch);
        dialogueRunner.AddCommandHandler("RaphIcon", RaphIconSwitch);
        dialogueRunner.AddCommandHandler("ScarecrowIcon", ScarecrowIconSwitch);
        
        //NPCs exclamation sprite:
        dialogueRunner.AddCommandHandler("MExplenationSprite", MExplenationSpriteSwitch);
        dialogueRunner.AddCommandHandler("CExplenationSprite", CExplenationSpriteSwitch);
        dialogueRunner.AddCommandHandler("QExplenationSprite", QExplenationSpriteSwitch);
        dialogueRunner.AddCommandHandler("WExplenationSprite", WExplenationSpriteSwitch);
        dialogueRunner.AddCommandHandler("BExplenationSprite", BExplenationSpriteSwitch);
        dialogueRunner.AddCommandHandler("RExplenationSprite", RExplenationSpriteSwitch);
        dialogueRunner.AddCommandHandler("SExplenationSprite", SExplenationSpriteSwitch);
        
        //Quest item sparkle sprite:
        dialogueRunner.AddCommandHandler("PSparkle", PeachSPARSwitch);
        dialogueRunner.AddCommandHandler("HSparkle", HoneySPARSwitch);
        dialogueRunner.AddCommandHandler("FloSparkle", FlowerSPARSwitch);
        dialogueRunner.AddCommandHandler("BSparkle", BerrySPARSwitch);
        dialogueRunner.AddCommandHandler("USparkle", UrchinSPARSwitch);
        dialogueRunner.AddCommandHandler("FirSparkle", FireflySPARSwitch);

        //Quest item mesh visibility:
        dialogueRunner.AddCommandHandler("PeachCollected", PeachVisibility);
        dialogueRunner.AddCommandHandler("HoneyCollected", HoneyVisibility);
        dialogueRunner.AddCommandHandler("BerryCollected", BerryVisibility);
        dialogueRunner.AddCommandHandler("FlowerCollected", FlowerVisibility);
        dialogueRunner.AddCommandHandler("UrchinCollected", UrchinVisibility);
        dialogueRunner.AddCommandHandler("FireflyCollected", FireflyVisibility);
        dialogueRunner.AddCommandHandler("ButtonEyesCollected", ButtonEyesVisibility);
        dialogueRunner.AddCommandHandler("HatCollected", HatVisibility);
    }

    //Quest items: Peach visibility.
    public void PeachVisibility()
    {
        if (PeachVisible == false)
        {
            PeachVisible = true;
        }
        else
        {
            PeachVisible = false;
        }
    }

    //Quest items: Honey visibility.
    public void HoneyVisibility()
    {
        if (HoneyVisible == false)
        {
            HoneyVisible = true;
        }
        else
        {
            HoneyVisible = false;
        }
    }

    //Quest items: Berry visibility.
    public void BerryVisibility()
    {
        if (BerryVisible == false)
        {
            BerryVisible = true;
        }
        else
        {
            BerryVisible = false;
        }
    }

    //Quest items: Flower visibility.
    public void FlowerVisibility()
    {
        if (FlowerVisible == false)
        {
            FlowerVisible = true;
        }
        else
        {
            FlowerVisible = false;
        }
    }

    //Quest items: Urchin visibility.
    public void UrchinVisibility()
    {
        if (UrchinVisible == false)
        {
            UrchinVisible = true;
        }
        else
        {
            UrchinVisible = false;
        }
    }

    //Quest items: Firefly visibility.
    public void FireflyVisibility()
    {
        if (FireflyVisible == false)
        {
            FireflyVisible = true;
        }
        else
        {
            FireflyVisible = false;
        }
    }

    //Quest items: ButtonEyes visibility.
    public void ButtonEyesVisibility()
    {
        if (ButtonEyesVisible == false)
        {
            ButtonEyesVisible = true;
        }
        else
        {
            ButtonEyesVisible = false;
        }
    }

    //Quest items: Hat visibility.
    public void HatVisibility()
    {
        if (HatVisible == false)
        {
            HatVisible = true;
        }
        else
        {
            HatVisible = false;
        }
    }

    //NPCs: Mush quest activation.
    public void MushQuestSwitch()
    {
        if (mushQuestActive == false)
        {
            mushQuestActive = true;
        }
        else
        {
            mushQuestActive = false;
        }

    }

    //NPCs: Choc Chip quest activation.
    public void ChipQuestSwitch()
    {
        if (chipQuestActive == false)
        {
           chipQuestActive = true;
        }
        else
        {
            chipQuestActive = false;
        }
    }

    //NPCs: Queenie quest activation.
    public void QueenieQuestSwitch()
    {
        if (queenieQuestActive == false)
        {
           queenieQuestActive = true;
        }
        else
        {
            queenieQuestActive = false;
        }
    }

    //NPCs: Bubbles quest activation.
    public void BubblesQuestSwitch()
    {
        if (bubblesQuestActive == false)
        {
           bubblesQuestActive  = true;
        }
        else
        {
            bubblesQuestActive  = false;
        }
    }

    //NPCs: Raph quest activation.
    public void RaphQuestSwitch()
    {
        if (raphQuestActive == false)
        {
           raphQuestActive  = true;
        }
        else
        {
            raphQuestActive  = false;
        }
    }

    //NPCs: Willow quest activation.
    public void WillowQuestSwitch()
    {
        if (willowQuestActive == false)
        {
           willowQuestActive  = true;
        }
        else
        {
            willowQuestActive  = false;
        }
    }

    //NPCs: Scarecrow straw quest activation.
    public void ScarecrowStrawSwitch()
    {
        if (scarecrowStrawQuestActive == false)
        {
           scarecrowStrawQuestActive  = true;
        }
        else
        {
            scarecrowStrawQuestActive  = false;
        }
    }

    //NPCs: Scarecrow button eyes quest activation.
    public void ScarecrowButtonSwitch()
    {
        if (scarecrowButtonQuestActive == false)
        {
           scarecrowButtonQuestActive  = true;
        }
        else
        {
            scarecrowButtonQuestActive  = false;
        }
    }

    //NPCs: Scarecrow hat quest activation.
    public void ScarecrowHatSwitch()
    {
        if (scarecrowHatQuestActive == false)
        {
           scarecrowHatQuestActive  = true;
        }
        else
        {
            scarecrowHatQuestActive  = false;
        }
    }

    //NPCs: Mush's image during dialogue.
    public void MushIconSwitch()
    {
        if (MushIconActive == false)
        {
            MushIconActive = true;
        }
        else
        {
            MushIconActive = false;
        }
    }

    //NPCs: Choc Chips's image during dialogue.
    public void ChipIconSwitch()
    {
        if (ChipIconActive == false)
        {
            ChipIconActive = true;
        }
        else
        {
            ChipIconActive = false;
        }
    }

    //NPCs: Queenie's image during dialogue.
    public void QueenieIconSwitch()
    {
        if (QueenieIconActive == false)
        {
            QueenieIconActive = true;
        }
        else
        {
            QueenieIconActive = false;
        }
    }

    //NPCs: Willow's image during dialogue.
    public void WillowIconSwitch()
    {
        if (WillowIconActive == false)
        {
            WillowIconActive = true;
        }
        else
        {
            WillowIconActive = false;
        }
    }

    //NPCs: Bubbles's image during dialogue.
    public void BubblesIconSwitch()
    {
        if (BubblesIconActive == false)
        {
            BubblesIconActive = true;
        }
        else
        {
            BubblesIconActive = false;
        }
    }

    //NPCs: Raph's image during dialogue.
    public void RaphIconSwitch()
    {
        if (RaphIconActive == false)
        {
            RaphIconActive = true;
        }
        else
        {
            RaphIconActive = false;
        }
    }

    //NPCs: Scarecrows's image during dialogue.
    public void ScarecrowIconSwitch()
    {
        if (ScarecrowIconActive == false)
        {
            ScarecrowIconActive = true;
        }
        else
        {
            ScarecrowIconActive = false;
        }
    }   

    //NPCs: Mush's exclamation sprite visibility:
    public void MExplenationSpriteSwitch()
    {
        if (MExplenationSprite == false)
        {
            MExplenationSprite  = true;
        }
        else
        {
            MExplenationSprite  = false;
        }
    }

    //NPCs: Choc Chip's exclamation sprite visibility:
    public void CExplenationSpriteSwitch()
    {
        if (CExplenationSprite == false)
        {
            CExplenationSprite  = true;
        }
        else
        {
            CExplenationSprite  = false;
        }
    }

    //NPCs: Queenie's exclamation sprite visibility:
    public void QExplenationSpriteSwitch()
    {
        if (QExplenationSprite == false)
        {
            QExplenationSprite  = true;
        }
        else
        {
            QExplenationSprite  = false;
        }
    }

    //NPCs: Willow's exclamation sprite visibility:
    public void WExplenationSpriteSwitch()
    {
        if (WExplenationSprite == false)
        {
           WExplenationSprite  = true;
        }
        else
        {
            WExplenationSprite  = false;
        }
    }

    //NPCs: Bubble's exclamation sprite visibility:
    public void BExplenationSpriteSwitch()
    {
        if (BExplenationSprite == false)
        {
            BExplenationSprite  = true;
        }
        else
        {
            BExplenationSprite  = false;
        }
    }

    //NPCs: Raph's exclamation sprite visibility:
    public void RExplenationSpriteSwitch()
    {
        if (RExplenationSprite == false)
        {
           RExplenationSprite  = true;
        }
        else
        {
            RExplenationSprite  = false;
        }
    }

    //NPCs: Scarecrow's exclamation sprite visibility:
    public void SExplenationSpriteSwitch()
    {
        if (SExplenationSprite == false)
        {
           SExplenationSprite  = true;
        }
        else
        {
            SExplenationSprite  = false;
        }
    }

    //Quest items: Peach sparkles.
    public void PeachSPARSwitch()
    {
        if (PeachSpriteActive == false)
        {
           PeachSpriteActive  = true;
        }
        else
        {
            PeachSpriteActive  = false;
        }
    }

    //Quest items: Honey sparkles.
    public void HoneySPARSwitch()
    {
        if (HoneySpriteActive == false)
        {
           HoneySpriteActive  = true;
        }
        else
        {
            HoneySpriteActive  = false;
        }
    }

    //Quest items: Flower sparkles.
    public void FlowerSPARSwitch()
    {
        if (FlowerSpriteActive == false)
        {
           FlowerSpriteActive  = true;
        }
        else
        {
            FlowerSpriteActive  = false;
        }
    }

    //Quest items: Berry sparkles.
    public void BerrySPARSwitch()
    {
        if (BerrySpriteActive == false)
        {
           BerrySpriteActive  = true;
        }
        else
        {
            BerrySpriteActive  = false;
        }
    }

    //Quest items: Urchin sparkles.
    public void UrchinSPARSwitch()
    {
        if (UrchinSpriteActive == false)
        {
           UrchinSpriteActive  = true;
        }
        else
        {
            UrchinSpriteActive  = false;
        }
    }

    //Quest items: Firefly sparkles.
    public void FireflySPARSwitch()
    {
        if (FireflySpriteActive == false)
        {
           FireflySpriteActive  = true;
        }
        else
        {
            FireflySpriteActive  = false;
        }
    }

    //Freezes player position during dialogue.
    public void PlayerFrezze()
    {
        if (playerMovement.inDialogue == false)
        {
           playerMovement.inDialogue  = true;
        }
        else
        {
            playerMovement.inDialogue  = false;
        }
    }
}