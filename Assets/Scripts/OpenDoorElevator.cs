using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OpenDoorElevator : MonoBehaviour
{
    [SerializeField] private ButtonElevator buttonElevator;

    [SerializeField] private Animator[] doors;

    public UnityAction<int> doorsMove;
    public UnityAction SpawnZombie;

    private void Start()
    {
        buttonElevator.elevatorOpen += OpenElevator;
    }

    private void OpenElevator()
    {
        for(int i = 0; i < doors.Length;i++)
        {
            doors[i].SetBool("open",true);
        }
        doorsMove?.Invoke(2);
        SpawnZombie?.Invoke();
    }
}
