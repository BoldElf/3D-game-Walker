using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    [SerializeField] private PlayerInvenotry playerInvenotry;
    [SerializeField] private Transform placeToTeleport;
    [SerializeField] private GameObject player;
    [SerializeField] private AudioSource soundPanel; 

    public void DoorOpen()
    {
        if(playerInvenotry.Key > 0)
        {
            player.transform.position = placeToTeleport.position;
            soundPanel.Stop();
        }
        else
        {
            Debug.Log("NoKey");
        }
        
    }
}
