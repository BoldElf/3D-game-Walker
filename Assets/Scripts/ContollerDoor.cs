using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContollerDoor : MonoBehaviour
{
    [SerializeField] private ZombieController zombieController;
    [SerializeField] private Collider colliderDoor;
    private OpenDoor openDoor;

    private void Start()
    {
        openDoor = gameObject.GetComponent<OpenDoor>();
        if (openDoor == null) return;
        zombieController.openDoor += DoorOpen;
    }

    private void DoorOpen()
    {
        colliderDoor.enabled = true;
    }
}
