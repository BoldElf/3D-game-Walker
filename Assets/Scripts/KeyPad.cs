using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class KeyPad : MonoBehaviour
{
    //[SerializeField] private ControllerTag controllerTag;
    [SerializeField] private PanelContollerDoor panelContoller;

    //public UnityAction KeyPadOn;

    private void Start()
    {
        //controllerTag.KeyOn += panelOn;
    }

    public void panelOn()
    {
        panelContoller.SetActive();
    }
}
