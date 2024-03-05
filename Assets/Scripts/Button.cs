using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    [SerializeField] private int number;

    private PasswordKeyPad PasswordKeyPad;

    private void Start()
    {
        PasswordKeyPad = gameObject.GetComponentInParent<PasswordKeyPad>();
    }

    public void numberEnter()
    {
        PasswordKeyPad.addNumber(number);
    }
}
