using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private CharacterController controller;
    [SerializeField] private float speed = 12f;
    [SerializeField] private float gravity = -9.81f;
    [SerializeField] private float jumpHight = 3f;

    [SerializeField] private Transform groundCheck;
    [SerializeField] private float groundSidtance = 0.4f;

    [SerializeField] private LayerMask groundMask;

    public UnityAction jumpOn;
    public UnityAction jumpOff;

    [SerializeField] private GameObject soundRun;

    Vector3 velocity;

    private bool isGrouned;


    void Update()
    {
        isGrouned = Physics.CheckSphere(groundCheck.position, groundSidtance, groundMask);

        if(isGrouned && velocity.y < 0 )
        {
            velocity.y = -2f;
            //jumpOff?.Invoke();
            soundRun.SetActive(true);
        }

        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * y;

        controller.Move(move * speed * Time.deltaTime);

        if(isGrouned && Input.GetButtonDown("Jump"))
        {
            //jumpOn?.Invoke();
            soundRun.SetActive(false);
            velocity.y = Mathf.Sqrt(jumpHight * -2f * gravity);
        }
        

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }
}
