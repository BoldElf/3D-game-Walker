using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ZombieController : MonoBehaviour
{
    [SerializeField] private OpenDoorElevator openDoorElevator;

    [SerializeField] private GameObject prefabZombie;

    private GameObject zombie;

    [SerializeField] private Animator animatorPrefab;

    [SerializeField] private float speed;
    [SerializeField] private int forceRotation;

    [SerializeField]private float timeToStartRun;
    [SerializeField] private float timerRotationLeft;
    [SerializeField] private float repeatTime;


    [SerializeField] private float timeDead;

    private float timer = 0;
    private bool goAudio;

    public UnityAction<int> spawnZombie;
    public UnityAction openDoor;

    public UnityAction onPanelSkrim;
    public UnityAction<int> ZombieWalkOn;
    public UnityAction<int> ZombieWalkOff;

    private void Start()
    {
        openDoorElevator.SpawnZombie += ZombieSpawn;
        enabled = false;
    }

    private void ZombieSpawn()
    {
        goAudio = true;
        enabled = true;
        spawnZombie?.Invoke(3);
        onPanelSkrim?.Invoke(); // PanelActive
        openDoor?.Invoke(); // ControllerDoor
        zombie = Instantiate(prefabZombie,gameObject.transform);
    }

    private Animator ZombieAnimator;

    private void Update()
    {
        MoveZombie();

        if(timerRotationLeft != 0)
        {
            rotationZombie();
        }
        

        Destroy(zombie, timeDead);

        if(timer >= timeDead)
        {
            ZombieWalkOff?.Invoke(4);
        }
    }

    private void rotationZombie()
    {
        if (timer >= timerRotationLeft && timer <= timerRotationLeft + repeatTime)
        {
            gameObject.transform.Rotate(0, -Time.deltaTime * forceRotation, 0);
        }
    }

    private void MoveZombie()
    {
        if (zombie != null)
        {
            timer += Time.deltaTime;

            if (timer >= timeToStartRun)
            {
                if (goAudio == true)
                {
                    ZombieWalkOn?.Invoke(4);
                    goAudio = false;
                }

                transform.Translate(Vector3.forward * speed * Time.deltaTime);
                ZombieAnimator = zombie.gameObject.GetComponent<Animator>();

                ZombieAnimator.SetBool("walk", true);
            }
        }

    }
}
