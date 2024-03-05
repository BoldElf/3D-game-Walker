using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class PasswordKeyPad : MonoBehaviour
{
    private bool[] number = new bool[10];

    [SerializeField] private int firestNumber;
    [SerializeField] private int secondNumber;
    [SerializeField] private DoorOpener door;

    public UnityAction<int> soundClick;

    [SerializeField] private Text text;

    public void addNumber(int value)
    {
        if(value == secondNumber)
        {
            if(number[firestNumber] == true)
            {
                number[value] = true;
            }
        }

        number[value] = true;

        text.text += value.ToString();

        Debug.Log(value);
    }

    public void checkPassword()
    {
        if (number[firestNumber] == true && number[secondNumber] == true)
        {
            number[firestNumber] = false;
            number[secondNumber] = false;

            for(int i = 0; i < number.Length;i++)
            {
                if (number[i] == true)
                {
                    ClearNumber();
                    Debug.Log("Wrong");

                    return;
                }
            }
            Debug.Log("doorOpen");
            door.open();
        }
        else
        {
            ClearNumber();
            Debug.Log("Wrong");
        }
        ClearText();
    }

    public void soundPlay()
    {
        soundClick?.Invoke(7);
    }

    public void ClearText()
    {
        text.text = null;
    }

    public void ClearNumber()
    {
        for (int i = 0; i < number.Length; i++)
        {
            number[i] = false;
        }
    }
}
