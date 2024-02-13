using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(BoxCollider))]
public class ZombiePlayerDamage : MonoBehaviour
{
    private CharacterController characterController;

    public UnityAction zombieKill;

    private void OnTriggerEnter(Collider other)
    {
        characterController = other.gameObject.GetComponent<CharacterController>();

        if(characterController != null)
        {
            zombieKill?.Invoke();
        }
    }
}
