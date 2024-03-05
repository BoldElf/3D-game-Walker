using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class KeyPickup : MonoBehaviour
{
    [SerializeField] private ControllerTag controllerLayer;

    public UnityAction plusKey;

    private void Start()
    {
        controllerLayer.pickupKey += keyPickup;
    }

    private void keyPickup(GameObject objectGame)
    {
        plusKey?.Invoke(); // PlayerInventory
        Destroy(objectGame);
    }
}
