using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BatteryPickup : MonoBehaviour
{
    [SerializeField] private ControllerTag controllerTag;

    public UnityAction plusBattery;

    private void Start()
    {
        controllerTag.pickupBattery += BatteryPlus;
    }

    private void BatteryPlus(GameObject objectGame)
    {
        //plusBattery?.Invoke();
        Destroy(objectGame);
    }
}
