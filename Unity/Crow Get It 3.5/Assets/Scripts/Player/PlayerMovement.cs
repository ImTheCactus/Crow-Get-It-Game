using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Variables:
    [SerializeField] private float moveSpeed;
    [SerializeField] private float walkSpeed;
    private Vector3 moveDirection;
    private Vector3 velocity;
    [SerializeField] private bool isGrounded;
    [SerializeField] private float groundCheckDistance;
    [SerializeField] private LayerMask groundMask;
    [SerializeField] private float gravity;
    [SerializeField] private float jumpHeight;
    private Rigidbody rb; //TEST

    //References:
    private CharacterController controller;
    private Animator anim;

    private void Start()
    {
        rb = GetComponent<Rigidbody>(); //TEST
        controller = GetComponent<CharacterController>();
        anim = GetComponentInChildren<Animator>();
    }

    private void Update()
    {
        Move();

        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            StartCoroutine(Attack());
        }
    }

    private void Move()
    {
        isGrounded = Physics.CheckSphere(transform.position, groundCheckDistance, groundMask);
        
        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float moveZ = Input.GetAxis("Vertical");
        float moveX = Input.GetAxis("Horizontal");
        moveDirection = new Vector3(moveX * moveSpeed, moveDirection.y, moveZ * moveSpeed);
        moveDirection = transform.TransformDirection(moveDirection);
        moveDirection *= walkSpeed;

        if(isGrounded == true)
        {
            if (moveDirection != Vector3.zero)
            {
                Walk();
            }

            else if (moveDirection == Vector3.zero)
            {
                Idle();
            }

            moveDirection *= moveSpeed;

            if (Input.GetKey(KeyCode.Space))
            {
                Jump();
            }
        }
        controller.Move(moveDirection * Time.deltaTime);
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);

        /*if (moveDirection != Vector3.zero)
        {
            Walk();
        }

        else if (moveDirection == Vector3.zero)
        {
            Idle();
        }

        moveDirection *= moveSpeed;

        if (Input.GetKey(KeyCode.Space))
        {
            Jump();
        }

        controller.Move(moveDirection * Time.deltaTime);
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);*/
    }


    private void Idle()
    {
        isGrounded = true;
        anim.SetFloat("Speed", 0f, 0.1f, Time.deltaTime);
    }
    private void Walk()
    {
        isGrounded = true;
        moveSpeed = walkSpeed;
        anim.SetFloat("Speed", 1f, 0.1f, Time.deltaTime);
    }

    private void Jump()
    {
        isGrounded = true;
        anim.SetTrigger("IsGrounded");
        velocity.y = Mathf.Sqrt(jumpHeight * -2 * gravity);
        isGrounded = false;
    }

    private IEnumerator Attack()
    {
        anim.SetLayerWeight(anim.GetLayerIndex("Attack Layer"), 1);
        anim.SetTrigger("Attack");
        yield return new WaitForSeconds(0.9f);
        anim.SetLayerWeight(anim.GetLayerIndex("Attack Layer"), 0);
    }
}
