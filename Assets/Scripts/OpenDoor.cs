using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    [SerializeField] private PlayerInvenotry playerInvenotry;

    public void DoorOpen()
    {
        if(playerInvenotry.Key > 0)
        {
            Debug.Log("open"); // !!!!  �������� ��� ������� �� ������ �����  !!!!
        }
        else
        {
            Debug.Log("NoKey");
        }
        
    }
}
