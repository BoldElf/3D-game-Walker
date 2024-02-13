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

    List<AudioClip> sound = new List<AudioClip>();



    void Start()
    {
        sound.Add(buttonElevatorSound);
        sound.Add(elevator);
        sound.Add(OpenDoorSound);
        sound.Add(spawnZombie);
        sound.Add(ZombieGo);

        buttonElevator.buttonSound += SoundButton;
        buttonElevator.elevatorSound += SoundButton;
        openDoorElevator.doorsMove += SoundButton;
        zombieController.spawnZombie += SoundButton;
        zombieController.ZombieWalkOn += SoundButton;
        zombieController.ZombieWalkOff += SoundOff;
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
