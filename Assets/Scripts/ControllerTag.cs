using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ControllerTag : MonoBehaviour
{
    [SerializeField] private Touch touch;

    public UnityAction buttonElevator;
    public UnityAction<GameObject> pickupKey;
    public UnityAction<GameObject> pickupBattery;
    public UnityAction<GameObject> KeyOn;

    private void Start()
    {
        touch.layerThereIs += IsThereLayer;
    }

    private KeyPad keyPad;

    private void IsThereLayer(string tag, GameObject objectGame)
    {
        if (tag == "Button") // 8 - Button
        {
            buttonElevator?.Invoke(); // ButtonElevator
        }

        if (tag == "Key") // 9 - Key
        {
            pickupKey?.Invoke(objectGame); // KeyPickup
        }
        if (tag == "Battery") 
        {
            pickupBattery?.Invoke(objectGame);
        }
        if(tag == "KeyPad")
        {
            //KeyOn?.Invoke(objectGame);
           keyPad = objectGame.GetComponent<KeyPad>();
           keyPad.panelOn();
        }
    }
}
