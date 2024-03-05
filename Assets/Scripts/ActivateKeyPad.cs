using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateKeyPad : MonoBehaviour
{
    [SerializeField] private DoorOpener doorOpener;

    private void Start()
    {
        doorOpener.doorOpen += openDoor;
    }

    private void openDoor()
    {
        gameObject.GetComponent<Collider>().enabled = false;
    }
}
