using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Flashlight : MonoBehaviour
{
    private Light lightObject;

    public UnityAction FlashlightTurn;

    [SerializeField] private float battery;
    [SerializeField] private float decrease;
    [SerializeField] private ControllerTag controllerTag;

    private void Start()
    {
        lightObject = gameObject.GetComponentInChildren<Light>();
        controllerTag.pickupBattery += BatteryPickup;
    }

    private void Update()
    {
        if (lightObject == null) return;
        if(Input.GetKeyDown(KeyCode.F))
        {
            if (battery <= 0f) return;
            FlashlightTurn?.Invoke();
            if (lightObject.isActiveAndEnabled)
            {
                lightObject.enabled = false;
            }
            else
            {
                lightObject.enabled = true;
            }
            
        }
    }

    private void FixedUpdate()
    {
        decreaseBattery();
    }

    private void decreaseBattery()
    {
        if (lightObject.isActiveAndEnabled)
        {
            if(battery > 0f)
            {
                battery -= decrease * Time.deltaTime;
                //Debug.Log(battery);
            }
            else
            {
                lightObject.enabled = false;
            }
        }
    }
    private void BatteryPickup(GameObject objectGame)
    {
        battery += 10;
    }
}
