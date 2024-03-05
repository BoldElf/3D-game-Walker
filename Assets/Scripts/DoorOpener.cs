using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DoorOpener : MonoBehaviour
{
    private Animator animator;

    public UnityAction<int> openSound;
    public UnityAction doorOpen;
    [SerializeField] private PanelContollerDoor panelContollerDoor;

    private void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    public void open()
    {
        panelContollerDoor.SetActive();
        animator.enabled = true;
        doorOpen?.Invoke();
        openSound?.Invoke(6);
    }
}
