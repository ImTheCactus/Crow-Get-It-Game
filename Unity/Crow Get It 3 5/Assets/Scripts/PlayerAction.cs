using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAction : MonoBehaviour
{
    private Animator mAnimator;
    // Start is called before the first frame update
    void Start()
    {
        mAnimator = GetComponent<Animator>();
    }

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
        }
    }
}
