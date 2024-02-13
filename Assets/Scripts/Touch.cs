using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Touch : MonoBehaviour
{
    //[SerializeField] private int layerMask;
    [SerializeField] private GameObject button;
    [SerializeField] private ButtonElevator obj;

    private OpenDoor openDoor;

    //public UnityAction buttonElevator;
    public UnityAction<int> layerThereIs;

    void Update()
    {
        /*
        RaycastHit hit;

        if (Physics.Raycast(transform.position, Camera.main.transform.forward + new Vector3(0,0.7f,0), out hit, Mathf.Infinity))
        {
            if(hit.collider.gameObject.layer == layerMask)
            {
                if(Input.GetKeyDown(KeyCode.E))
                {
                    buttonElevator?.Invoke();
                }
            }
            Debug.DrawRay(transform.position, Camera.main.transform.forward * hit.distance, Color.yellow);
        }
        */
        RaycastHit hit;

        if (Physics.Raycast(transform.position, Camera.main.transform.forward + new Vector3(0, 1f, 0), out hit, Mathf.Infinity))
        {
            if (hit.collider.gameObject.layer != 0 && hit.collider.gameObject.layer != LayerMask.NameToLayer("Door")) // 0 - default
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    layerThereIs?.Invoke(hit.collider.gameObject.layer); // contollerLayer
                }
            }
            if (hit.collider.gameObject.layer == LayerMask.NameToLayer("Door"))
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    openDoor = hit.collider.gameObject.GetComponent<OpenDoor>();
                    if(openDoor != null)
                    {
                        openDoor.DoorOpen();
                    }
                    
                }
                    
            }
            Debug.DrawRay(transform.position, Camera.main.transform.forward * hit.distance, Color.yellow);
        }

    }
}
