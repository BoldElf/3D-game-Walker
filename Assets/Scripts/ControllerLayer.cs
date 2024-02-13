using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ControllerLayer : MonoBehaviour
{
    [SerializeField] private Touch touch;

    public UnityAction buttonElevator;
    public UnityAction pickupKey;

    private void Start()
    {
        touch.layerThereIs += IsThereLayer;
    }

    private void IsThereLayer(int layer)
    {
        if(layer == LayerMask.NameToLayer("Button")) // 8 - Button
        {
            buttonElevator?.Invoke(); // ButtonElevator
        }

        if (layer == LayerMask.NameToLayer("Key")) // 9 - Key
        {
            pickupKey?.Invoke(); // KeyPickup
        }
    }
}
