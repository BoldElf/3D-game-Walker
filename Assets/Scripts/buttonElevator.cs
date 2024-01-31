using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonElevator : MonoBehaviour
{
    [SerializeField] private Touch touch;

    private void Start()
    {
        touch.buttonElevator += startProcess;
    }

    private void startProcess()
    {
        Debug.Log("Press");
    }
}
