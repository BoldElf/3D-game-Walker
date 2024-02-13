using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Animator))]
public class ButtonElevator : MonoBehaviour
{
    //[SerializeField] private Touch touch;
    [SerializeField] private ControllerLayer controllerLayer;
    private Animator animator;

    [SerializeField] private float timeToReload;
    private float timer;
    private bool press = false;
    private bool elevator = false;

    public UnityAction <int> buttonSound;
    public UnityAction<int>  elevatorSound;

    public UnityAction elevatorOpen;

    private void Start()
    {
        enabled = false;
        animator = gameObject.GetComponent<Animator>();
        controllerLayer.buttonElevator += startProcess;
    }

    private void Update()
    {
        if (press == true)
        {
            if (timer >= 0)
            {
                timer -= Time.deltaTime;
            }
            else
            {
                animator.SetBool("button", false);
                press = false;
                enabled = false;
                elevatorOpen?.Invoke();
            }
            if (timer <= timeToReload - timeToReload / 10 && elevator == true)
            {
                elevatorSound?.Invoke(1);
                elevator = false;
            }
        }
    }

    private void startProcess()
    {
        if (press == false)
        {
            timer = timeToReload;
            animator.SetBool("button", true);
            buttonSound?.Invoke(0);
            press = true;
            enabled = true;
            elevator = true;
        }
    }
}
