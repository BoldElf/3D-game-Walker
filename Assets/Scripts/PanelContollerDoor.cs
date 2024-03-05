using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelContollerDoor : MonoBehaviour
{
    [SerializeField]private MouseLook mouseLook;
    [SerializeField]private GameObject panel;

    private bool panelOn = false;

    public void SetActive()
    {
        if(panelOn == false)
        {
            mouseLook.enabled = false;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.Confined;
            panel.SetActive(true);
            panelOn = true;
        }
        else
        {
            mouseLook.enabled = true;
            panel.SetActive(false);
            panelOn = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
        
    }
}
