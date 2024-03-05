using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SoundScript : MonoBehaviour
{
    [SerializeField]private AudioSource audioSource;

    [SerializeField] private AudioClip buttonElevatorSound;
    [SerializeField] private ButtonElevator buttonElevator;

    [SerializeField] private AudioClip OpenDoorSound;
    [SerializeField] private OpenDoorElevator openDoorElevator;

    [SerializeField] private AudioClip spawnZombie;
    [SerializeField] private ZombieController zombieController;

    [SerializeField] private AudioClip elevator;

    [SerializeField] private AudioClip ZombieGo;

    [SerializeField] private AudioClip hitSound;
    [SerializeField] private PlayerHealth playerHealth;

    [SerializeField] private AudioClip doorSound;
    [SerializeField] private DoorOpener doorOpener;

    [SerializeField] private AudioClip clickSound;
    [SerializeField] private PasswordKeyPad passwordKeyPad;

    List<AudioClip> sound = new List<AudioClip>();



    void Start()
    {
        sound.Add(buttonElevatorSound);
        sound.Add(elevator);
        sound.Add(OpenDoorSound);
        sound.Add(spawnZombie);
        sound.Add(ZombieGo);
        sound.Add(hitSound);
        sound.Add(doorSound);
        sound.Add(clickSound);

        buttonElevator.buttonSound += SoundButton;
        buttonElevator.elevatorSound += SoundButton;
        openDoorElevator.doorsMove += SoundButton;
        zombieController.spawnZombie += SoundButton;
        zombieController.ZombieWalkOn += SoundButton;
        zombieController.ZombieWalkOff += SoundOff;
        playerHealth.damageSound += SoundButton;
        doorOpener.openSound += SoundButton;
        passwordKeyPad.soundClick += SoundButton;

    }

    private void SoundButton(int number)
    {
        audioSource.clip = sound[number];
        audioSource.Play();

        if(number == 4)
        {
            audioSource.loop = true;
        }
    }

    private void SoundOff(int number)
    {
        audioSource.Stop();
        audioSource.loop = false;
    }

}
