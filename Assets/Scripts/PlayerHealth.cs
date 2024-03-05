using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private ZombiePlayerDamage zombiePlayerDamage;

    [SerializeField] private int playerHealth;

    public UnityAction <int> damageSound;

    private void Start()
    {
        zombiePlayerDamage.zombieKill += deathPlayer;
    }

    public void damagePlayer()
    {
        if(playerHealth > 0)
        {
            playerHealth -= 1;
            damageSound(5);
        }
        ZeroHealth();
    }


    private void deathPlayer()
    {
        playerHealth = 0;
        ZeroHealth();
    }

    private void ZeroHealth()
    {
        if(playerHealth <= 0)
        {
            Debug.Log("PlayerDeath"); // Заглушка под смерть player-a!
        }
    }

    private void Update()
    {
        
    }
}
