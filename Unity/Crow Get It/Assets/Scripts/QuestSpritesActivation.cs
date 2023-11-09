using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine;
using System.Collections;

public class QuestSpritesActivation : MonoBehaviour
{
    public PlayerMovement playerMovement;
    public CustomYarnCommands customYarnCommands;

    //NPCs references:
    [Header("NPC GameObjects")]
    public GameObject player;
    public GameObject MushExplenationSprite;
    public GameObject ChipExplenationSprite;
    public GameObject QueenieExplenationSprite;
    public GameObject WillowExplenationSprite;
    public GameObject BubblesExplenationSprite;
    public GameObject RaphExplenationSprite;
    public GameObject ScareExplenationSprite;

    //Quest items references:
    [Header("Quest Items GameObjects")]
    public GameObject PeachSprite;
    public GameObject HoneySprite;
    public GameObject FlowerSprite;
    public GameObject BerrySprite;
    public GameObject UrchinSprite;
    public GameObject FireflySprite;

    public GameObject PeachObject;
    public GameObject HoneyObject;
    public GameObject BerryObject;
    public GameObject FlowerObject;
    public GameObject UrchinObject;
    public GameObject FireflyObject;
    //Hay object has been excluded.
    public GameObject ButtonEyesObject;
    public GameObject HatObject;

    //NPCs variables:
    public bool Pcontroller = true;
    public bool MExplenationSprite = true; //Mush.
    public bool CExplenationSprite = true; //Choc Chip.
    public bool QExplenationSprite = true; //Queenie.
    public bool WExplenationSprite = true; //Willow.
    public bool BExplenationSprite = true; //Bubbles.
    public bool RExplenationSprite = true; //Raph.
    public bool SExplenationSprite = true; //Scarecrow.

    //Quest items variables:
    public bool PeachSpriteActive = false;
    public bool HoneySpriteSpriteActive = false;
    public bool FlowerSpriteActive = false;
    public bool BerrySpriteActive = false;
    public bool UrchinSpriteActive = false;
    public bool FireflySpriteActive = false;

    public bool PeachVisible = true;
    public bool HoneyVisible = true;
    public bool BerryVisible = true;
    public bool FlowerVisible = true;
    public bool UrchinVisible = true;
    public bool FireflyVisible = true;
    public bool ButtonEyesVisible = true;
    public bool HatVisible = true;

    //Start is called before the first frame update.
    void Start()
    {
        //Freeze player movement during dialogue.
        playerMovement.inDialogue = false;

        //Quest items: Mesh visibility is set to visible.
        PeachObject.SetActive(true);
        HoneyObject.SetActive(true);
        BerryObject.SetActive(true);
        FlowerObject.SetActive(true);
        UrchinObject.SetActive(true);
        FireflyObject.SetActive(true);
        ButtonEyesObject.SetActive(true);
        HatObject.SetActive(true);

        //NPCs: Exclamation sprite is set to visible.
        MushExplenationSprite.SetActive(true);
        ChipExplenationSprite.SetActive(true);
        QueenieExplenationSprite.SetActive(true);
        WillowExplenationSprite.SetActive(true);
        BubblesExplenationSprite.SetActive(true);
        RaphExplenationSprite.SetActive(true);
        ScareExplenationSprite.SetActive(true);
       
        //Quest items: Sparkle sprite set to invisible.
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
        //Quest items: Peach visibility and scaling.
        if (customYarnCommands.PeachVisible == true)
        {
            PeachObject.SetActive(true);
        }
        else if (customYarnCommands.PeachVisible == false)
        {
            //Repeats encased code until the gameObject's scale is small, then hides the gameObject.
            for (int i = 0; i < 1; i++)
            {
                //Infinitely decreases scale with an interval of 0.01f.
                Vector3 gameObjectScale = new Vector3(0.01f, 0.01f, 0.01f);
                PeachObject.transform.localScale -= gameObjectScale;

                //Triggers when gameObject is equal to or less than the desired scale.
                if (PeachObject.transform.localScale == -gameObjectScale)
                {
                    //Stops repeated decrease in scale.
                    PeachObject.transform.localScale = new Vector3(0f, 0f, 0f);
                    //Hides gameObject.
                    PeachObject.SetActive(false);
                }
            }
        }

        //Quest items: Honey visibility and scaling.
        if (customYarnCommands.HoneyVisible == true)
        {
            HoneyObject.SetActive(true);
        }
        else if (customYarnCommands.HoneyVisible == false)
        {
            //Repeats encased code until the gameObject's scale is small, then hides the gameObject.
            for (int i = 0; i < 1; i++)
            {
                //Infinitely decreases scale with an interval of 0.01f.
                Vector3 gameObjectScale = new Vector3(0.01f, 0.01f, 0.01f);
                HoneyObject.transform.localScale -= gameObjectScale;

                //Triggers when gameObject is equal to or less than the desired scale.
                if (HoneyObject.transform.localScale == -gameObjectScale)
                {
                    //Stops repeated decrease in scale.
                    HoneyObject.transform.localScale = new Vector3(0f, 0f, 0f);
                    //Hides gameObject.
                    HoneyObject.SetActive(false);
                }
            }
        }

        //Quest items: Berry visibility and scaling.
        if (customYarnCommands.BerryVisible == true)
        {
            BerryObject.SetActive(true);
        }
        else if (customYarnCommands.BerryVisible == false)
        {
            //Repeats encased code until the gameObject's scale is small, then hides the gameObject.
            for (int i = 0; i < 1; i++)
            {
                //Infinitely decreases scale with an interval of 0.01f.
                Vector3 gameObjectScale = new Vector3(0.5f, 0.5f, 0.5f);
                BerryObject.transform.localScale -= gameObjectScale;

                //Triggers when gameObject is equal to or less than the desired scale.
                if (BerryObject.transform.localScale == -gameObjectScale)
                {
                    //Stops repeated decrease in scale.
                    BerryObject.transform.localScale = new Vector3(0f, 0f, 0f);
                    //Hides gameObject.
                    BerryObject.SetActive(false);
                }
            }
        }

        //Quest items: Flower visibility and scaling.
        if (customYarnCommands.FlowerVisible == true)
        {
            FlowerObject.SetActive(true);
        }
        else if (customYarnCommands.FlowerVisible == false)
        {
            //Repeats encased code until the gameObject's scale is small, then hides the gameObject.
            for (int i = 0; i < 1; i++)
            {
                //Infinitely decreases scale with an interval of 0.01f.
                Vector3 gameObjectScale = new Vector3(0.01f, 0.01f, 0.01f);
                FlowerObject.transform.localScale -= gameObjectScale;

                //Triggers when gameObject is equal to or less than the desired scale.
                if (FlowerObject.transform.localScale == -gameObjectScale)
                {
                    //Stops repeated decrease in scale.
                    FlowerObject.transform.localScale = new Vector3(0f, 0f, 0f);
                    //Hides gameObject.
                    FlowerObject.SetActive(false);
                }
            }
        }

        //Quest items: Urchin visibility and scaling.
        if (customYarnCommands.UrchinVisible == true)
        {
            UrchinObject.SetActive(true);
        }
        else if (customYarnCommands.UrchinVisible == false)
        {
            //Repeats encased code until the gameObject's scale is small, then hides the gameObject.
            for (int i = 0; i < 1; i++)
            {
                //Infinitely decreases scale with an interval of 0.01f.
                Vector3 gameObjectScale = new Vector3(0.5f, 0.5f, 0.5f);
                UrchinObject.transform.localScale -= gameObjectScale;

                //Triggers when gameObject is equal to or less than the desired scale.
                if (UrchinObject.transform.localScale == -gameObjectScale)
                {
                    //Stops repeated decrease in scale.
                    UrchinObject.transform.localScale = new Vector3(0f, 0f, 0f);
                    //Hides gameObject.
                    UrchinObject.SetActive(false);
                }
            }
        }

        //Quest items: Firefly visibility and scaling.
        if (customYarnCommands.FireflyVisible == true)
        {
            FireflyObject.SetActive(true);
        }
        else if (customYarnCommands.FireflyVisible == false)
        {
            //Repeats encased code until the gameObject's scale is small, then hides the gameObject.
            for (int i = 0; i < 1; i++)
            {
                //Infinitely decreases scale with an interval of 0.01f.
                Vector3 gameObjectScale = new Vector3(0.5f, 0.5f, 0.5f);
                FireflyObject.transform.localScale -= gameObjectScale;

                //Triggers when gameObject is equal to or less than the desired scale.
                if (FireflyObject.transform.localScale == -gameObjectScale)
                {
                    //Stops repeated decrease in scale.
                    FireflyObject.transform.localScale = new Vector3(0f, 0f, 0f);
                    //Hides gameObject.
                    FireflyObject.SetActive(false);
                }
            }
        }

        //Quest items: ButtonEyes visibility and scaling.
        if (customYarnCommands.ButtonEyesVisible == true)
        {
            ButtonEyesObject.SetActive(true);
        }
        else if (customYarnCommands.ButtonEyesVisible == false)
        {
            //Repeats encased code until the gameObject's scale is small, then hides the gameObject.
            for (int i = 0; i < 1; i++)
            {
                //Infinitely decreases scale with an interval of 0.01f.
                Vector3 gameObjectScale = new Vector3(0.01f, 0.01f, 0.01f);
                ButtonEyesObject.transform.localScale -= gameObjectScale;

                //Triggers when gameObject is equal to or less than the desired scale.
                if (ButtonEyesObject.transform.localScale == -gameObjectScale)
                {
                    //Stops repeated decrease in scale.
                    ButtonEyesObject.transform.localScale = new Vector3(0f, 0f, 0f);
                    //Hides gameObject.
                    ButtonEyesObject.SetActive(false);
                }
            }
        }

        //Quest items: Hat visibility and scaling.
        if (customYarnCommands.HatVisible == true)
        {
            HatObject.SetActive(true);
        }
        else if (customYarnCommands.HatVisible == false)
        {
            //Repeats encased code until the gameObject's scale is small, then hides the gameObject.
            for (int i = 0; i < 1; i++)
            {
                //Infinitely decreases scale with an interval of 0.01f.
                Vector3 gameObjectScale = new Vector3(0.01f, 0.01f, 0.01f);
                HatObject.transform.localScale -= gameObjectScale;

                //Triggers when gameObject is equal to or less than the desired scale.
                if (HatObject.transform.localScale == -gameObjectScale)
                {
                    //Stops repeated decrease in scale.
                    HatObject.transform.localScale = new Vector3(0f, 0f, 0f);
                    //Hides gameObject.
                    HatObject.SetActive(false);
                }
            }
        }

        //NPCs: Mush's exclamation sprite visibility.
        if (customYarnCommands.MExplenationSprite == true)
        {
            //Shows gameObject.
            MushExplenationSprite.SetActive(true);
        }
        else if (customYarnCommands.MExplenationSprite == false)
        {
            //Hides gameObject.
            MushExplenationSprite.SetActive(false);
        }

        //NPCs: Choc Chip's exclamation sprite visibility.
        if (customYarnCommands.CExplenationSprite == true)
        {
            //Shows gameObject.
            ChipExplenationSprite.SetActive(true);
        }
        else if (customYarnCommands.CExplenationSprite == false)
        {
            //Hides gameObject.
            ChipExplenationSprite.SetActive(false);
        }

        //NPCs: Queenie's exclamation sprite visibility.
        if (customYarnCommands.QExplenationSprite == true)
        {
            //Shows gameObject.
            QueenieExplenationSprite.SetActive(true);
        }
        else if (customYarnCommands.QExplenationSprite == false)
        {
            //Hides gameObject.
            QueenieExplenationSprite.SetActive(false);
        }

        //NPCs: Willow's exclamation sprite visibility.
        if (customYarnCommands.WExplenationSprite == true)
        {
            //Shows gameObject.
            WillowExplenationSprite.SetActive(true);
        }
        else if (customYarnCommands.WExplenationSprite == false)
        {
            //Hides gameObject.
            WillowExplenationSprite.SetActive(false);
        }

        //NPCs: Bubbles's exclamation sprite visibility.
        if (customYarnCommands.BExplenationSprite == true)
        {
            //Shows gameObject.
            BubblesExplenationSprite.SetActive(true);
        }
        else if (customYarnCommands.BExplenationSprite == false)
        {
            //Hides gameObject.
            BubblesExplenationSprite.SetActive(false);
        }

        //NPCs: Raph's exclamation sprite visibility.
        if (customYarnCommands.RExplenationSprite == true)
        {
            //Shows gameObject.
            RaphExplenationSprite.SetActive(true);
        }
        else if (customYarnCommands.RExplenationSprite == false)
        {
            //Hides gameObject.
            RaphExplenationSprite.SetActive(false);
        }

        //NPCs: Scarecrows's exclamation sprite visibility.
        if (customYarnCommands.SExplenationSprite == true)
        {
            //Shows gameObject.
            ScareExplenationSprite.SetActive(true);
        }
        else if (customYarnCommands.SExplenationSprite == false)
        {
            //Hides gameObject.
            ScareExplenationSprite.SetActive(false);
        }

        //Quest items: Peach sparkle sprite visibility.
        if (customYarnCommands.PeachSpriteActive == true)
        {
            //Shows gameObject.
            PeachSprite.SetActive(true);
        }
        else if (customYarnCommands.HoneySpriteActive == false)
        {
            //Hides gameObject.
           PeachSprite.SetActive(false);
        }

        //Quest items: Honey sparkle sprite visibility.
        if (customYarnCommands.HoneySpriteActive == true)
        {
            //Shows gameObject.
            HoneySprite.SetActive(true);
        }
        else if (customYarnCommands.HoneySpriteActive == false)
        {
            //Hides gameObject.
            HoneySprite.SetActive(false);
        }

        //Quest items: Flower sparkle sprite visibility.
        if (customYarnCommands.FlowerSpriteActive == true)
        {
            //Shows gameObject.
            FlowerSprite.SetActive(true);
        }
        else if (customYarnCommands.FlowerSpriteActive == false)
        {
            //Hides gameObject.
            FlowerSprite.SetActive(false);
        }

        //Quest items: Berry sparkle sprite visibility.
        if (customYarnCommands.BerrySpriteActive == true)
        {
            //Shows gameObject.
            BerrySprite.SetActive(true);
        }
        else if (customYarnCommands.BerrySpriteActive == false)
        {
            //Hides gameObject.
            BerrySprite.SetActive(false);
        }

        //Quest items: Urchin sparkle sprite visibility.
        if (customYarnCommands.UrchinSpriteActive == true)
        {
            //Shows gameObject.
            UrchinSprite.SetActive(true);
        }
        else if (customYarnCommands.UrchinSpriteActive == false)
        {
            //Hides gameObject.
            UrchinSprite.SetActive(false);
        }

        //Quest items: Firefly sparkle sprite visibility.
        if (customYarnCommands.FireflySpriteActive == true)
        {
            //Shows gameObject.
            FireflySprite.SetActive(true);
        }
        else if (customYarnCommands.FireflySpriteActive == false)
        {
            //Hides gameObject.
            FireflySprite.SetActive(false);
        }

        //LEAVE ME
       /* 
        if (customYarnCommands.Pcontroller == true)
        {
            playerMovement.inDialogue = true;
        }
        else if (customYarnCommands.Pcontroller == false)
        {
            playerMovement.inDialogue = false;
        }
       */
    }
}