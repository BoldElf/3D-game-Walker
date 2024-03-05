using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Touch : MonoBehaviour
{
    [SerializeField] private GameObject button;
    [SerializeField] private ButtonElevator obj;

    private OpenDoor openDoor;

    public UnityAction<string,GameObject> layerThereIs;

    void Update()
    {
        int layerMaskWithoutDefault = 0;

        RaycastHit hit;

        if (Physics.Raycast(transform.position, Camera.main.transform.forward + new Vector3(0, 1f, 0), out hit, Mathf.Infinity, ~layerMaskWithoutDefault))
        {
            if (hit.collider.gameObject.tag != "Untagged" && hit.collider.gameObject.tag != "Door") // 0 - default
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    layerThereIs?.Invoke(hit.collider.gameObject.tag, hit.collider.gameObject); // contollerTag
                }
            }
            if (hit.collider.gameObject.tag == "Door")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    openDoor = hit.collider.gameObject.GetComponent<OpenDoor>();
                    if (openDoor != null)
                    {
                        openDoor.DoorOpen();
                    }

                }

            }
            Debug.DrawRay(transform.position, Camera.main.transform.forward * hit.distance, Color.yellow);
        }
    }
}
