using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class KeyPickup : MonoBehaviour
{
    [SerializeField] private ControllerLayer controllerLayer;

    public UnityAction plusKey;

    private void Start()
    {
        controllerLayer.pickupKey += keyPickup;
    }

    private void keyPickup()
    {
        plusKey?.Invoke(); // PlayerInventory
        Destroy(gameObject);
    }
}
