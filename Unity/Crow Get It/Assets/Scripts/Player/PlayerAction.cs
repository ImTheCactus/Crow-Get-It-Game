using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerAction : MonoBehaviour
{
    private Animator mAnimator;
    // Start is called before the first frame update
    void Start()
    {
        mAnimator = GetComponent<Animator>();
    }

    float idleTimer = 0f;
    bool isIdle = true;

    

    // Update is called once per frame
    void Update()
    {
        
        
        if (mAnimator != null)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                mAnimator.SetTrigger("BeginWalking");
            }

            if (Input.GetKeyDown(KeyCode.A))
            {
                mAnimator.SetTrigger("BeginWalking");
            }

            if (Input.GetKeyDown(KeyCode.S))
            {
                mAnimator.SetTrigger("BeginWalking");
            }

            if (Input.GetKeyDown(KeyCode.D))
            {
                mAnimator.SetTrigger("BeginWalking");
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                mAnimator.SetTrigger("StartJump");
            }

            if (Input.GetKeyDown(KeyCode.E))
            {
                mAnimator.SetTrigger("IsPeck");
            }

            if (Input.anyKey)
            {
                idleTimer = 0f;
                isIdle = false;
            }
            else
            {
                idleTimer += Time.deltaTime;
                if (idleTimer >= 2f && !isIdle)
                {
                    // Play idle animation

                    mAnimator.SetTrigger("IsIdle");
                }
            }
        }
    }
}
