using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private ZombiePlayerDamage zombiePlayerDamage;

    [SerializeField] private int playerHealth;

    private void Start()
    {
        zombiePlayerDamage.zombieKill += deathPlayer;
    }


    private void deathPlayer()
    {
        playerHealth = 0;
    }

    private void Update()
    {
        if(playerHealth == 0)
        {
            Debug.Log("PlayerDeath"); // Заглушка под смерть player-a!
        }
    }
}
