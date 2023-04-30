using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
#if USE_INPUTSYSTEM && ENABLE_INPUT_SYSTEM
using UnityEngine.InputSystem;
#endif

namespace Yarn.Unity.Example
{
    public class PlayerCharacter : MonoBehaviour
    {
        public float interactionRadius = 2.0f;

        // because we are using the same button press for both starting and skipping dialogue they collide
        // so we are going to make it so that the input gets turned off
        private DialogueAdvanceInput dialogueInput;

        void Start()
        {
            dialogueInput = FindObjectOfType<DialogueAdvanceInput>();
            dialogueInput.enabled = false;
        }

        /// <summary>
        /// Draw the range at which we'll start talking to people.
        /// </summary>
        void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.blue;

            // Flatten the sphere into a disk, which looks nicer in 2D
            // games
            Gizmos.matrix = Matrix4x4.TRS(transform.position, Quaternion.identity, new Vector3(1, 1, 0));

            // Need to draw at position zero because we set position in the
            // line above
            Gizmos.DrawWireSphere(Vector3.zero, interactionRadius);
        }

        /// <summary>
        /// Update is called once per frame
        /// </summary>
        void Update()
        {
            // Remove all player control when we're in dialogue
            if (FindObjectOfType<DialogueRunner>().IsDialogueRunning == true)
            {
                return;
            }

            // every time we LEAVE dialogue we have to make sure we disable the input again
            if (dialogueInput.enabled)
            {
                dialogueInput.enabled = false;
            }

            

            // Detect if we want to start a conversation
#if USE_INPUTSYSTEM && ENABLE_INPUT_SYSTEM
            if (Keyboard.current.spaceKey.wasPressedThisFrame) {
                CheckForNearbyNPC ();
            }
#elif ENABLE_LEGACY_INPUT_MANAGER
            if (Input.GetKeyUp(KeyCode.Space))    // may be able to switch this to "E"
            {
                CheckForNearbyNPC();
            }
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                SceneManager.LoadScene("MainMenu");
            }
#endif
        }

        /// <summary>
        /// Find all DialogueParticipants
        /// </summary>
        /// <remarks>
        /// Filter them to those that have a Yarn start node and are in
        /// range; then start a conversation with the first one
        /// </remarks>
        public void CheckForNearbyNPC()
        {
            var allParticipants = new List<NPC>(FindObjectsOfType<NPC>());
            var target = allParticipants.Find(delegate (NPC p)
            {
                return string.IsNullOrEmpty(p.talkToNode) == false && // has a conversation node?
                (p.transform.position - this.transform.position)// is in range?
                .magnitude <= interactionRadius;
            });
            if (target != null)
            {
                // Kick off the dialogue at this node.
                FindObjectOfType<DialogueRunner>().StartDialogue(target.talkToNode);
                // reenabling the input on the dialogue
                dialogueInput.enabled = true;
            }
        }
    }
}
