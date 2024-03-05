using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageZone : MonoBehaviour
{
    [SerializeField] private Transform playerTeleport;
    [SerializeField] private GameObject player;
    private PlayerHealth playerHealth;
    private CharacterController characterController;
    private bool teleport = false;

    private void OnTriggerEnter(Collider other)
    {
        playerHealth = other.GetComponent<PlayerHealth>();
        characterController = other.GetComponent<CharacterController>();


        if (playerHealth != null)
        {
            teleport = true;
        }
    }
    private float timer;

    private void Update()
    {
        if(teleport == true)
        {
            timer += Time.deltaTime;
        }

        if(timer >= 0.5)
        {
            teleport = false;
            timer = 0;
            playerHealth.damagePlayer();
            characterController.enabled = false;
            player.transform.position = playerTeleport.position;
            characterController.enabled = true;
        }
    }
}
